using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LUMO.Core.Clock
{
    /// <summary>
    /// 
    /// </summary>
    public static class ClockFactory
    {
        private static ClockManager clock;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isTicking"></param>
        /// <returns></returns>
        public static ClockManager ClockBasic(bool isTicking = false)
        {
            clock = new ClockManager();
            clock.IsTicking = isTicking;
            return clock;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="isTicking"></param>
        /// <returns></returns>
        public static ClockManager ClockWithMiliseconds(int interval, bool isTicking = false)
        {
            ClockManager clock = new ClockManager(new DateTimeFormat("HH:MM:ss:ffff"), interval);
            return clock;
        }
    }
}
