using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LUMO.Core.Formatters
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringFormatter
    {
        /// <summary>
        /// Format string with first character in uppercase
        /// </summary>
        /// <param name="value"></param>
        /// <returns>String with first character in uppercase</returns>
        public static string FirstCharToUpper(string value)
        {
            switch (value)
            {
                case null: throw new ArgumentNullException(nameof(value));
                case "": throw new ArgumentException("Value cannot be empty.", nameof(value));
                default: return value.First().ToString().ToUpper() + value.Substring(1);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FirstCharInSentenceUpper(string value)
        {
            throw new NotImplementedException();
        }
    }
}
