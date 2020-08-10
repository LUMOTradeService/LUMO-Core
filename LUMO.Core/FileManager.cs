using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LUMO.Core
{
    /// <summary>
    /// At this moment it just has static methods.
    /// But some day... 
    /// TO DO: Documentation
    /// </summary>
    public class FileManager
    {
        private FileSystemWatcher fileSystemWatcher;

        /// <summary>
        /// Current directory
        /// </summary>
        public string CurrentDirectory { get; set; }
        /// <summary>
        /// Backup directory
        /// </summary>
        public string BackupDirectory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] Files
        {
            get
            {
                return GetFiles(CurrentDirectory);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public FileManager()
        {
            fileSystemWatcher = new FileSystemWatcher();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        public FileManager(string directory) : this()
        {
            CurrentDirectory = directory;
        }

        /// <summary>
        /// Save file with contents in CurrentDirectory.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="contents"></param>
        public void Save(string fileName, string contents)
        {
            Save(CurrentDirectory, fileName, contents);
        }
        /// <summary>
        /// Load file with requested fileName from CurrentDirectory.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string Load(string fileName)
        {
            return Load(CurrentDirectory, fileName);
        }
        /// <summary>
        /// Delete file from CurrentDirecotry.
        /// </summary>
        /// <param name="fileName"></param>
        public void Delete(string fileName)
        {
            Delete(CurrentDirectory, fileName);
        }
        /// <summary>
        /// Encrypt file located in CurrentDirectory.
        /// </summary>
        /// <param name="fileName"></param>
        public void Encrypt(string fileName)
        {
            Encrypt(fileName);
        }
        /// <summary>
        /// Decrypt file located in CurrentDirectory.
        /// </summary>
        /// <param name="fileName"></param>
        public void Decrypt(string fileName)
        {
            Decrypt(fileName);
        }

        #region Static

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileName"></param>
        /// <param name="contents"></param>
        public static void Save(string directory, string fileName, string contents)
        {
            File.WriteAllText(Path.Combine(directory, fileName), contents);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileName"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public static void Save(string directory, string fileName, string contents, Encoding encoding)
        {
            File.WriteAllText(Path.Combine(directory, fileName), contents, encoding);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string Load(string directory, string fileName)
        {
            return File.ReadAllText(Path.Combine(directory, fileName));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileName"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string Load(string directory, string fileName, Encoding encoding)
        {
            return File.ReadAllText(Path.Combine(directory, fileName), encoding);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileName"></param>
        public static void Delete(string directory, string fileName)
        {
            File.Delete(Path.Combine(directory, fileName));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceDirectory"></param>
        /// <param name="sourceFileName"></param>
        /// <param name="destDirectory"></param>
        /// <param name="destFileName"></param>
        public static void Copy(string sourceDirectory, string sourceFileName, string destDirectory, string destFileName)
        {
            File.Copy(Path.Combine(sourceDirectory, sourceFileName), Path.Combine(destDirectory, destFileName));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceDirectory"></param>
        /// <param name="sourceFileName"></param>
        /// <param name="destDirectory"></param>
        /// <param name="destFileName"></param>
        public static void Move(string sourceDirectory, string sourceFileName, string destDirectory, string destFileName)
        {
            File.Move(Path.Combine(sourceDirectory, sourceFileName), Path.Combine(destDirectory, destFileName));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceDirectory"></param>
        /// <param name="sourceFileName"></param>
        /// <param name="destDirectory"></param>
        /// <param name="destFileName"></param>
        /// <param name="backupDirectory"></param>
        /// <param name="backupFileName"></param>
        public static void Replace(string sourceDirectory, string sourceFileName, string destDirectory, string destFileName, string backupDirectory, string backupFileName)
        {
            File.Replace(Path.Combine(sourceDirectory, sourceFileName), Path.Combine(destDirectory, destFileName), Path.Combine(backupDirectory, backupFileName));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileName"></param>
        public static void Encrypt(string directory, string fileName)
        {
            File.Encrypt(Path.Combine(directory, fileName));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileName"></param>
        public static void Decrypt(string directory, string fileName)
        {
            File.Decrypt(Path.Combine(directory, fileName));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static string GetFirstFile(string directory)
        {
            return Directory.GetFiles(directory)[0];
        }
        /// <summary>
        /// Get all files in folder.
        /// </summary>
        /// <param name="directory">folder path.</param>
        /// <returns>List of files.</returns>
        public static string[] GetFiles(string directory)
        {
            return Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
        }
        /// <summary>
        /// Get all files in folder that ends with suffix.
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="filters">(Examples: exe, dll, png, etx...)</param>
        /// <param name="isRecursive"></param>
        /// <returns>List of filtered files.</returns>
        public static string[] GetFiles(string directory, string[] filters, bool isRecursive = true)
        {
            return GetFiles(directory, "", filters, isRecursive);
        }
        /// <summary>
        /// Get All Files in Folder that begins with [fileNameBegin] string.
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileNameBegin"></param>
        /// <param name="filters">(Examples: exe, dll, png, etx...)</param>
        /// <param name="isRecursive"></param>
        /// <returns>List of filtered files.</returns>
        public static string[] GetFiles(string directory, string fileNameBegin, string[] filters, bool isRecursive = true)
        {
            List<string> files = new List<string>();
            SearchOption searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (string filter in filters)
            {
                files.AddRange(Directory.GetFiles(directory, $"{fileNameBegin}*.{filter}", searchOption));
            }
            return files.ToArray();
        }

        #endregion
    }
}
