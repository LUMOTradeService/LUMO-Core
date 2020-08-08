using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Core
{
    /// <summary>
    /// Realy, realy, realy simple calculator
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Add two numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result</returns>
        public static double Addition(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// Subtract two numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result</returns>
        public static double Subrtaction(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// Divide two numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result</returns>
        public static double Division(double a, double b)
        {
            return a / b;
        }
        /// <summary>
        /// Multiply two numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Result</returns>
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
    }
}
