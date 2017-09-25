using System;
using System.Windows;
using System.IO;
using System.ComponentModel;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Diagnostics;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;

namespace MoskvinWorkers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Автозагрузка последней сессии

        private bool _loadLastSession = true;

        /// <summary>
        /// Загружать последнюю сессию.
        /// </summary>
        public bool LoadLastSession 
        {
            get { return _loadLastSession; }
            set { _loadLastSession = value; }
        }

        #endregion

        #region Копирование папок

        private bool _isCopyAllFolder = false;

        /// <summary>
        /// Копирование папки целиком.
        /// </summary>
        public bool IsCopyAllFolder
        {
            get { return _isCopyAllFolder; }
            set { _isCopyAllFolder = value; }
        }

        #endregion

        /// <summary>
        /// Список файлов для обновления.
        /// </summary>
        Files MyFiles { get; set; }

#region Свойства - пути к файлам

        /// <summary>
        /// Путь к новому файлу, который нужно копировать.
        /// </summary>
        string PathToNewFile { get; set; }

        /// <summary>
        /// Путь к файлу, который нужно заменить при синхронизации.
        /// </summary>
        string PathToNewSyncFile { get; set; }

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            Sizes windowSizes = new Sizes();
            this.Height = windowSizes.WinSize.Height;
            this.Width = windowSizes.WinSize.Width;
            this.Left = windowSizes.WinSize.Left;
            this.Top = windowSizes.WinSize.Top;
            this.WindowState = windowSizes.WinSize.State;

            this.DataContext = this;

            MyFiles = new Files(LoadLastSession);
            grid.ItemsSource = MyFiles.FileList;

            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            MyFiles.SaveSession(); // Сохранить список файлов.

            Sizes windowSizes = new Sizes();            
            windowSizes.WinSize.Height = this.Height;
            windowSizes.WinSize.Width = this.Width;
            windowSizes.WinSize.Left = this.Left;
            windowSizes.WinSize.Top = this.Top;
            windowSizes.WinSize.State = this.WindowState;
            windowSizes.SaveWindowSize();
        }



        private void menuClearList_Click(object sender, RoutedEventArgs e)
        {
            // Очистить список синхронизации.
            if (MessageBox.Show("Вы действительно хотите очистить список синхронизации полностью?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    MyFiles.FileList.Clear();
                    MessageBox.Show("Список синхронизации успешно очищен.", "Очищено", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось очистить список.\nПричина:\n" + ex.Message, "Очистка не удалась", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Empty_SingleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid.SelectedIndex = -1; // Снимаем выделение строки.
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            grid.SelectAll();
        }



        private void Hyperlink_SyncFileInfoNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Посмотреть информацию о файле.
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            var tb = ((Hyperlink)e.OriginalSource).DataContext; // Получаем путь для синхронизации.

            MyFiles.GetSyncFileInfo(tb.ToString());
        }

        private void Hyperlink_RequestRemoveNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Удаляем из списка путей синхронизаций.
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            var tb = ((Hyperlink)e.OriginalSource).DataContext; // Получаем путь для синхронизации.
            MyFiles.RemovePath(selectedRow, tb.ToString());
            grid.UnselectAll();
        }

        private void Hyperlink_RequestEditNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Редактируем путь синхронизации.
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            var tb = ((Hyperlink)e.OriginalSource).DataContext; // Получаем путь для синхронизации.

            if (MyFiles.FileList[selectedRow].FileType == 0) // Это файл.
            {
                PathToNewSyncFile = new SelectFiles().OpenFileDialog(); // Открыть диалог для выбора нового файла.
            }
            else
            {
                PathToNewSyncFile = new SelectFiles().OpenFolderDialog(); // Открыть диалог для выбора папки.
            }

            if (PathToNewSyncFile != null)
            {
                MyFiles.EditPath(selectedRow, tb.ToString(), PathToNewSyncFile); // Изменить путь синхронизации.
            }
        }


        /* События выделения и снятия выделения строки в таблице. */
        private void DataGridRow_Selected(object sender, RoutedEventArgs e)
        {
            // Выделили строку.            
        }

        private void DataGridRow_Unselected(object sender, RoutedEventArgs e)
        {
            // Сняли выделение со строки.            
        }



        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Owner = this;
            about.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        /* События для перемещения файлов в программу. */

        public delegate Point GetGragDropPosition(IInputElement theElement);

        private DataGridRow GetDataGridRowItem(int index)
        {
            if (grid.ItemContainerGenerator.Status != System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
            {
                return null;
            }
            return grid.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow;
        }

        /// <summary>
        /// Находится ли указатель над объектом.
        /// </summary>
        /// <param name="theTarget"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        private bool IsTheMouseOnTargetRow(Visual theTarget, GetGragDropPosition pos)
        {
            Rect posBound = VisualTreeHelper.GetDescendantBounds(theTarget);
            Point theMousePos = pos((IInputElement)theTarget);
            return posBound.Contains(theMousePos);
        }

        /// <summary>
        /// Получить индекс строки, над которой находится указатель мыши.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        private int GetDataGridItemCurrentRowIndex(GetGragDropPosition pos)
        {
            int curIndex = -1;
            for (int i = 0; i < grid.Items.Count; i++)
            {
                DataGridRow itm = GetDataGridRowItem(i);
                if (IsTheMouseOnTargetRow(itm, pos))
                {
                    curIndex = i;
                    break;
                }
            }
            return curIndex;
        }

        private void text_PreviewDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                int prevRowIndex = GetDataGridItemCurrentRowIndex(e.GetPosition);
                if (prevRowIndex < 0)
                {
                    grid.UnselectAll();
                    return;
                }
                grid.SelectedIndex = prevRowIndex;
                e.Effects = DragDropEffects.Copy;
            }
        }

        private void text_PreviewDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {                
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                foreach (string file in files)
                {
                    int selectedRow = grid.SelectedIndex;
                    FileInfo ff = new FileInfo(file);
                    if (selectedRow == -1)
                    {
                        PathToNewFile = ff.FullName; // Путь к файлу.
                        if (PathToNewFile != null)
                        {
                            MyFiles.AddNewFile(PathToNewFile); // Добавить новый файл в список источников.
                        }
                    }
                    else
                    {
                        PathToNewSyncFile = ff.FullName;
                        switch (MyFiles.FileList[selectedRow].FileType)
                        {
                            case 0:
                                if (PathToNewSyncFile != null)
                                {
                                    // Попытка добавить к источнику типа "Файл" файл.
                                    // Что добавляем к источнику: файл или папку.
                                    if (new FileInfo(PathToNewSyncFile).Exists == true)
                                    {
                                        MyFiles.AddPath(selectedRow, PathToNewSyncFile);
                                    }
                                    else
                                    {
                                        // Попытка добавить к источнику типа "Файл" папку.
                                        MyFiles.AddPath(selectedRow, PathToNewSyncFile += @"\" + MyFiles.FileList[selectedRow].FileName);
                                    }
                                }
                                break;
                            case 1:
                                if (PathToNewSyncFile != null)
                                {
                                    // Попытка добавить к источнику типа "Файл" файл.
                                    // Что добавляем к источнику: файл или папку.
                                    if (new FileInfo(PathToNewSyncFile).Exists == true)
                                    {
                                        MessageBox.Show("Нельзя добавлять файл к источнику типа 'Папка'!\nПопробуйте указать папку.",
                                            "Не верно выбран источник",
                                            MessageBoxButton.OK, MessageBoxImage.Error);
                                        return;
                                    }
                                    else
                                    {
                                        // Попытка добавить к источнику типа "Файл" папку.
                                        MyFiles.AddPath(selectedRow, PathToNewSyncFile);
                                    }
                                }
                                break;
                        }
                    }
                }
            }
        }




        /* Анализ списка. */
        private void btnAnalysis_Click(object sender, RoutedEventArgs e)
        {
            Analizator analize = new Analizator();
            System.Collections.Generic.List<int> updatingRows = analize.AnalizeFileStart(MyFiles);

            grid.UnselectAll();
            //SolidColorBrush hb = new SolidColorBrush(Colors.HotPink); // Этим цветом будем подсвечивать строки, которые нужно обновить.
            SolidColorBrush hb = new SolidColorBrush(Colors.Pink); // Этим цветом будем подсвечивать строки, которые нужно обновить.
            foreach (int index in updatingRows)
            {
                if (index != -1)
                {
                    DataGridRow row = (DataGridRow)grid.ItemContainerGenerator.ContainerFromIndex(index);
                    row.Background = hb;
                }
            }

            MessageBox.Show("Анализ произведен!", "Анализ выполнен", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /* Синхронизация. */
        private void btnSync_Click(object sender, RoutedEventArgs e)
        {
            // Нажимаем кнопку "Синхронизировать".
            Syncronizing doSync = new Syncronizing();
            doSync.SyncronizeFileStart(MyFiles);
        }

        /* Добавление в Избранное */
        private void btnAddFavorits_Click(object sender, RoutedEventArgs e)
        {
            // Добавить файл в избранное.
            MessageBox.Show("Добавили в избранное");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileModel row = (FileModel)grid.SelectedItems[0];
            //FileModel row = (DataRowView)grid.SelectedItems[0] as FileModel;
            MessageBox.Show(row.FileID.ToString());
        }




        private void DataGridRow_MouseRightButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid.UnselectAll();
            ((DataGridRow)sender).IsSelected = true;

            ContextMenu menu = new ContextMenu();

            MenuItem fileInfo = new MenuItem();
            fileInfo.Header = "Информация о источнике";
            fileInfo.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Image/info.ico"))
            };
            fileInfo.Click += FileInfo_Click;
            menu.Items.Add(fileInfo);

            MenuItem openFolder = new MenuItem();
            openFolder.Header = "Открыть в проводнике";
            openFolder.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Image/16/openfolder.ico"))
            };
            openFolder.Click += OpenFolder_Click;
            menu.Items.Add(openFolder);

            MenuItem editRoot = new MenuItem();
            editRoot.Header = "Редактировать источник";
            editRoot.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Image/edit.ico"))
            };
            editRoot.Click += btnEditRoot_Click;
            menu.Items.Add(editRoot);

            MenuItem clearPathList = new MenuItem();
            clearPathList.Header = "Очистить список путей";
            clearPathList.ToolTip = "Очистить список путей у выбранного источника.";
            clearPathList.Click += (s, n) => MyFiles.ClearPathList(grid.SelectedIndex);
            menu.Items.Add(clearPathList);

            MenuItem clearRoot = new MenuItem();
            clearRoot.Header = "Удалить источник";
            clearRoot.ToolTip = "Удалить выделенный источник из списка.";
            clearRoot.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Image/delete.ico"))
            };
            clearRoot.Click += btnRemoveRoot_Click;
            menu.Items.Add(clearRoot);

            menu.IsOpen = true;
        }

        private void OpenFolder_Click(object sender, RoutedEventArgs e)
        {
            Oppening.OpenInWindowsExplorer(MyFiles.FileList[grid.SelectedIndex].FilePath);
        }

        private void FileInfo_Click(object sender, RoutedEventArgs e)
        {
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            switch(MyFiles.FileList[selectedRow].FileType)
            {
                case 0:
                    MyFiles.GetFileInfo(selectedRow);
                    break;
                case 1:
                    MyFiles.GetFolderInfo(selectedRow);
                    break;
            }
        }



        private void btnAddRootFile_Click(object sender, RoutedEventArgs e)
        {
            PathToNewFile = new SelectFiles().OpenFileDialog(); // Открыть диалог для выбора нового файла.
            MyFiles.AddNewFile(PathToNewFile); // Добавить новый файл в список синхронизаций.
        }

        private void btnAddRootFolder_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = new SelectFiles().OpenFolderDialog();
            MyFiles.AddNewFile(folderPath); // Добавить папку в список синхронизаций.
        }

        private void btnEditRoot_Click(object sender, RoutedEventArgs e)
        {
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            if (selectedRow == -1)
            {
                MessageBox.Show("Вы не выбрали источник!\nПожалуйста, выберите источник, а затем изменяйте его!",
                    "Не выбран источник",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            switch (MyFiles.FileList[selectedRow].FileType)
            {
                case 0:
                    PathToNewFile = new SelectFiles().OpenFileDialog(); // Открыть диалог для выбора нового файла.
                    break;
                case 1:
                    PathToNewFile = new SelectFiles().OpenFolderDialog();
                    break;
            }
            MyFiles.EditFile(selectedRow, PathToNewFile); // Добавить новый файл в список синхронизаций.
        }

        private void btnRemoveRoot_Click(object sender, RoutedEventArgs e)
        {
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            if (selectedRow == -1)
            {
                MessageBox.Show("Вы не выбрали источник!\nПожалуйста, выберите источник, а затем удаляйте его!",
                    "Не выбран источник",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (MessageBox.Show("ВНИМАНИЕ!\nПри удалении источника будут удалены и пути для него.\nВы уверены?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MyFiles.RemoveFile(selectedRow);
            }
        }

        private void btnAddSyncFile_Click(object sender, RoutedEventArgs e)
        {
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            if (selectedRow == -1)
            {
                MessageBox.Show("Вы не выбрали источник!\nПожалуйста, выберите источник, а затем добавляйте файл в список адресатов!",
                    "Не выбран источник",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (MyFiles.FileList[selectedRow].FileType == 1)
            {
                MessageBox.Show("Нельзя добавлять файл к источнику типа 'Папка'!\nПопробуйте указать папку.",
                    "Не верно выбран источник",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            PathToNewSyncFile = new SelectFiles().OpenSaveFileDialog(MyFiles.FileList[selectedRow].FileName); // Добавляем путь к источнику.
            MyFiles.AddPath(selectedRow, PathToNewSyncFile); // Добавляем новый файл в список обновляемых.
        }

        private void btnAddSyncFolder_Click(object sender, RoutedEventArgs e)
        {
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            if(selectedRow == -1)
            {
                MessageBox.Show("Вы не выбрали источник!\nПожалуйста, выберите источник, а затем добавляйте папку в список адресатов!", 
                    "Не выбран источник", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string folderPath = new SelectFiles().OpenFolderDialog();
            MyFiles.AddPath(selectedRow, folderPath); // Добавляем папку в список адресатов.
        }

        private void gridSelectedRow_DoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int selectedRow = grid.SelectedIndex; // Номер выделенной строки.
            switch(MyFiles.FileList[selectedRow].FileType)
            {
                case 0:
                    PathToNewSyncFile = new SelectFiles().OpenSaveFileDialog(MyFiles.FileList[selectedRow].FileName); // Добавляем путь к источнику.
                    MyFiles.AddPath(selectedRow, PathToNewSyncFile); // Добавляем новый файл в список обновляемых.
                    break;
                case 1:
                    string folderPath = new SelectFiles().OpenFolderDialog();
                    MyFiles.AddPath(selectedRow, folderPath); // Добавляем папку в список адресатов.
                    break;
            }
        }

        private void btnDeleteSelectedRows_Click(object sender, RoutedEventArgs e)
        {
            /*var selected = Table.SelectedItems as ObservableCollection<diskInform>;
            if (selected != null && selected.Any())
            {
                //получить картинки, первой колонки
                var images = selected.Select(x => x.img);
            }
            */
            var selectedRows = grid.SelectedItems;
            if (selectedRows.Count <= 0)
            {
                MessageBox.Show("Вы не выбрали ни одной строки!\nВыделите строки, а затем удаляйте их!", "Нет источников", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                
            }
        }
    }
}
