using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LUMO.Core
{
    /// <summary>
    /// At this it just returns list of files in folder.
    /// But I will add Save/Load/Delete... some day.
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// Get all files in folder.
        /// </summary>
        /// <param name="folder">folder path.</param>
        /// <returns>List of files.</returns>
        public static string[] GetFiles(string folder)
        {
            return Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
        }
        /// <summary>
        /// Get all files in folder that ends with suffix.
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="filters">(Examples: exe, dll, png, etx...)</param>
        /// <param name="isRecursive"></param>
        /// <returns>List of filtered files.</returns>
        public static string[] GetFiles(string folder, string[] filters, bool isRecursive = true)
        {
            return GetFiles(folder, "", filters, isRecursive);
        }
        /// <summary>
        /// Get All Files in Folder that begins with [fileNameBegin] string.
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="fileNameBegin"></param>
        /// <param name="filters">(Examples: exe, dll, png, etx...)</param>
        /// <param name="isRecursive"></param>
        /// <returns>List of filtered files.</returns>
        public static string[] GetFiles(string folder, string fileNameBegin, string[] filters, bool isRecursive = true)
        {
            List<string> files = new List<string>();
            SearchOption searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (string filter in filters)
            {
                files.AddRange(Directory.GetFiles(folder, $"{fileNameBegin}*.{filter}", searchOption));
            }
            return files.ToArray();
        }
    }
}
