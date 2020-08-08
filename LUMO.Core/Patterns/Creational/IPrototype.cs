using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Core.Patterns.Creational
{
    /// <summary>
    /// Prototype Pattern Interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPrototype<T>
    {
        /// <summary>
        /// Get clone of itself.
        /// </summary>
        /// <returns>Clone of itself</returns>
        T Clone();
    }
}
