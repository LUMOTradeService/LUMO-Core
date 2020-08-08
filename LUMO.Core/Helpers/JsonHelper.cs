using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LUMO.Core.Helpers
{
    /// <summary>
    /// Serialize/Deserialize 
    /// </summary>
    public class JsonHelper
    {
        /// <summary>
        /// Json to object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns>Object</returns>
        public static async Task<T> ToObjectAsync<T>(string value)
        {
            return await Task.Run<T>(() =>
            {
                return JsonConvert.DeserializeObject<T>(value);
            });
        }
        /// <summary>
        /// Object to json.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Json string</returns>
        public static async Task<string> StringifyAsync(object value)
        {
            return await Task.Run<string>(() =>
            {
                return JsonConvert.SerializeObject(value);
            });
        }
    }
}
