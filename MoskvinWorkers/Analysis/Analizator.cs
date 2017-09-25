using System;
using System.Collections.Generic;
using System.IO;

namespace MoskvinWorkers
{
    class Analizator
    {
        public Analizator()
        {

        }

        /// <summary>
        /// Произвести анализ источников и путей.
        /// </summary>
        /// <param name="MyFiles">Список файлов.</param>
        public List<int> AnalizeFileStart(Files MyFiles)
        {
            return GetIndexes(MyFiles);
        }

        /// <summary>
        /// Получить индексы источников, где необходимо обновление.
        /// </summary>
        /// <returns></returns>
        private List<int> GetIndexes(Files MyFiles)
        {
            List<int> rowUpdating = new List<int>();
            foreach (FileModel file in MyFiles.FileList)
            {
                switch(file.FileType)
                {
                    case 0:
                        rowUpdating.Add(GetFileIndex(file));
                        break;
                    case 1:
                        rowUpdating.Add(GetFileIndex(file));
                        break;
                }

                
            }
            return rowUpdating;
        }

        /// <summary>
        /// Сравнение источника и путей для одного файла.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private int GetFileIndex(FileModel file)
        {
            int index = -1;
            DateTime changeOfRoot = new FileInfo(file.FilePath).LastWriteTime;
            foreach (string path in file.PathToCopy)
            {
                DateTime changeOfPath = new FileInfo(path).LastWriteTime;
                if (changeOfRoot.Date > changeOfPath.Date)
                {
                    index = file.FileID - 1;
                }
                else if (changeOfRoot.Hour > changeOfPath.Hour)
                {
                    index = file.FileID - 1;
                }
                else if (changeOfRoot.Minute > changeOfPath.Minute)
                {
                    index = file.FileID - 1;
                }
                else if (changeOfRoot.Second > changeOfPath.Second)
                {
                    index = file.FileID - 1;
                }
            }
            return index;
        }

        /// <summary>
        /// Сравнение источников и путей для одной папки.
        /// </summary>
        /// <returns></returns>
        private int[] GetFolderIndex(FileModel file)
        {
            FileInfo[] filePathes = new DirectoryInfo(file.FilePath).GetFiles(); // Список файлов в папке.
            int[] index = new int[filePathes.Length];

            foreach(FileInfo filePath in filePathes)
            {
                
            }

            return index;
        }
    }
}
