using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LUMO.Core
{
    public class FileManager
    {
        public static string[] GetFiles(string folder)
        {
            return Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
        }
        public static string[] GetFiles(string folder, string[] filters, bool isRecursive = true)
        {
            return GetFiles(folder, "", filters, isRecursive);
        }
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
