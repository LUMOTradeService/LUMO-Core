using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Core
{
    /// <summary>
    /// Generates random things... (int, string, etc.) 
    /// </summary>
    public static class Generate
    {
        private static Random random = new Random();

        /// <summary>
        /// Get random int.
        /// </summary>
        /// <returns>Integer</returns>
        public static int RandomInt()
        {
            return random.Next();
        }
        /// <summary>
        /// Get random int from 0 to max.
        /// </summary>
        /// <param name="max"></param>
        /// <returns>Interger between 0 to max</returns>
        public static int RandomInt(int max)
        {
            return random.Next(max);
        }
        /// <summary>
        /// Get random int from min to max.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Interger between min to max</returns>
        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max);
        }
        /// <summary>
        /// Get random double from 0.0 to 1.0.
        /// </summary>
        /// <returns>Double between 0.0 to 1.0</returns>
        public static double RandomDouble()
        {
            return random.NextDouble();
        }
        /// <summary>
        /// Get random double from 0.0 to 1.0 time (multiplier).
        /// </summary>
        /// <param name="multiplier"></param>
        /// <returns>Double between 0.0 to 1.0 (multiplier)</returns>
        public static double RandomDouble(int multiplier)
        {
            return random.NextDouble() * multiplier;
        }
    }
}
