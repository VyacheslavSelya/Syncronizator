﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7DCA194D6ECCB96A0FFD35D3B7F11635"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MoskvinWorkers;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MoskvinWorkers {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 277 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuRemoveFile;
        
        #line default
        #line hidden
        
        
        #line 294 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuRemovePath;
        
        #line default
        #line hidden
        
        
        #line 301 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuDoSync;
        
        #line default
        #line hidden
        
        
        #line 306 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuSelectList;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuClearList;
        
        #line default
        #line hidden
        
        
        #line 308 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuClearSelectedRoots;
        
        #line default
        #line hidden
        
        
        #line 312 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuLastSession;
        
        #line default
        #line hidden
        
        
        #line 319 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuHelp;
        
        #line default
        #line hidden
        
        
        #line 324 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuAbout;
        
        #line default
        #line hidden
        
        
        #line 333 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid;
        
        #line default
        #line hidden
        
        
        #line 539 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSync;
        
        #line default
        #line hidden
        
        
        #line 546 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnalysis;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Syncronizer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 262 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddRootFile_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 267 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddRootFolder_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 272 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditRoot_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.menuRemoveFile = ((System.Windows.Controls.MenuItem)(target));
            
            #line 277 "..\..\MainWindow.xaml"
            this.menuRemoveFile.Click += new System.Windows.RoutedEventHandler(this.btnRemoveRoot_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 284 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddSyncFile_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 289 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddSyncFolder_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.menuRemovePath = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            
            #line 297 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAnalysis_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.menuDoSync = ((System.Windows.Controls.MenuItem)(target));
            
            #line 301 "..\..\MainWindow.xaml"
            this.menuDoSync.Click += new System.Windows.RoutedEventHandler(this.btnSync_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.menuSelectList = ((System.Windows.Controls.MenuItem)(target));
            
            #line 306 "..\..\MainWindow.xaml"
            this.menuSelectList.Click += new System.Windows.RoutedEventHandler(this.btnSelectAll_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.menuClearList = ((System.Windows.Controls.MenuItem)(target));
            
            #line 307 "..\..\MainWindow.xaml"
            this.menuClearList.Click += new System.Windows.RoutedEventHandler(this.menuClearList_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.menuClearSelectedRoots = ((System.Windows.Controls.MenuItem)(target));
            
            #line 308 "..\..\MainWindow.xaml"
            this.menuClearSelectedRoots.Click += new System.Windows.RoutedEventHandler(this.btnDeleteSelectedRows_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.menuLastSession = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 14:
            this.menuHelp = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 15:
            this.menuAbout = ((System.Windows.Controls.MenuItem)(target));
            
            #line 324 "..\..\MainWindow.xaml"
            this.menuAbout.Click += new System.Windows.RoutedEventHandler(this.menuAbout_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 330 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 335 "..\..\MainWindow.xaml"
            this.grid.PreviewDragEnter += new System.Windows.DragEventHandler(this.text_PreviewDragEnter);
            
            #line default
            #line hidden
            
            #line 336 "..\..\MainWindow.xaml"
            this.grid.PreviewDragOver += new System.Windows.DragEventHandler(this.text_PreviewDragEnter);
            
            #line default
            #line hidden
            
            #line 337 "..\..\MainWindow.xaml"
            this.grid.PreviewDrop += new System.Windows.DragEventHandler(this.text_PreviewDrop);
            
            #line default
            #line hidden
            return;
            case 31:
            this.btnSync = ((System.Windows.Controls.Button)(target));
            
            #line 539 "..\..\MainWindow.xaml"
            this.btnSync.Click += new System.Windows.RoutedEventHandler(this.btnSync_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            this.btnAnalysis = ((System.Windows.Controls.Button)(target));
            
            #line 546 "..\..\MainWindow.xaml"
            this.btnAnalysis.Click += new System.Windows.RoutedEventHandler(this.btnAnalysis_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 18:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeftButtonDownEvent;
            
            #line 341 "..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.Empty_SingleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 19:
            
            #line 407 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddRootFile_Click);
            
            #line default
            #line hidden
            break;
            case 20:
            
            #line 410 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddRootFolder_Click);
            
            #line default
            #line hidden
            break;
            case 21:
            
            #line 429 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenFolder_Click);
            
            #line default
            #line hidden
            break;
            case 22:
            
            #line 432 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FileInfo_Click);
            
            #line default
            #line hidden
            break;
            case 23:
            
            #line 435 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditRoot_Click);
            
            #line default
            #line hidden
            break;
            case 24:
            
            #line 438 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnRemoveRoot_Click);
            
            #line default
            #line hidden
            break;
            case 25:
            
            #line 456 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddSyncFile_Click);
            
            #line default
            #line hidden
            break;
            case 26:
            
            #line 459 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddSyncFolder_Click);
            
            #line default
            #line hidden
            break;
            case 27:
            
            #line 483 "..\..\MainWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_SyncFileInfoNavigate);
            
            #line default
            #line hidden
            break;
            case 28:
            
            #line 490 "..\..\MainWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestEditNavigate);
            
            #line default
            #line hidden
            break;
            case 29:
            
            #line 497 "..\..\MainWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestRemoveNavigate);
            
            #line default
            #line hidden
            break;
            case 30:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 514 "..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.gridSelectedRow_DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseRightButtonUpEvent;
            
            #line 515 "..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DataGridRow_MouseRightButtonUp);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.DataGridRow.SelectedEvent;
            
            #line 517 "..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.RoutedEventHandler(this.DataGridRow_Selected);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.DataGridRow.UnselectedEvent;
            
            #line 518 "..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.RoutedEventHandler(this.DataGridRow_Unselected);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

