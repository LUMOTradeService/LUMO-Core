using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Core.Patterns.Creational
{
    /// <summary>
    /// Singleton Pattern Abstract.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Singleton<T> : ISingleton<T> where T : new()
    {
        private static T instance;
        /// <summary>
        /// Get Instance of T object.
        /// </summary>
        public static T Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
}
