using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Core.Patterns.Creational
{
    /// <summary>
    /// Prototype Pattern Abstract.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Prototype<T> : IPrototype<T>
    {
        /// <summary>
        /// Get clone of itself.
        /// </summary>
        /// <returns>Clone of itself</returns>
        public abstract T Clone();
    }
}
