using LUMO.Core.Delegates;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

namespace LUMO.Core
{
    /// <summary>
    /// Not so precise clock :D.
    /// </summary>
    public class ClockManager
    {
        private DateTime startTime;
        private DateTime currentTime;
        private Timer timer;
        private int interval = 1000;
        private bool isTicking = false;

        /// <summary>
        /// Get current time.
        /// </summary>
        public string Time
        {
            get
            {
                return currentTime.ToString(TimeFormat.FormatString);
            }
        }
        /// <summary>
        /// Get elapsed time.
        /// </summary>
        public TimeSpan TimeElapsed { get; private set; }
        /// <summary>
        /// Get or set time format
        /// </summary>
        public DateTimeFormat TimeFormat { get; set; } = new DateTimeFormat("HH:MM:ss");
        /// <summary>
        /// Get or set update time interval.
        /// </summary>
        public int Interval
        {
            get
            {
                return interval;
            }
            set
            {
                interval = value;
                timer.Change(StartingTime(Interval), interval);
            }
        }
        /// <summary>
        /// Start or stop clock.
        /// </summary>
        public bool IsTicking
        {
            get
            {
                return isTicking;
            }
            set
            {
                isTicking = value;
                OnTickingStateChanged?.Invoke(isTicking);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public ClockManager()
        {
            startTime = DateTime.Now;
            timer = new Timer(new TimerCallback(TimerTask), IsTicking, StartingTime(Interval), Interval);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFormat"></param>
        /// <param name="interval"></param>
        public ClockManager(DateTimeFormat timeFormat, int interval) : this()
        {
            TimeFormat = timeFormat;
            Interval = interval;
            
            timer = new Timer(new TimerCallback(TimerTask), IsTicking, StartingTime(Interval), Interval);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFormat"></param>
        /// <param name="interval"></param>
        /// <param name="isRunning"></param>
        public ClockManager(DateTimeFormat timeFormat, int interval, bool isRunning) : this(timeFormat, interval)
        {
            IsTicking = isRunning;
        }

        /// <summary>
        /// Raised when interval elapsed.
        /// </summary>
        public event IntervalElapsedHandler OnIntervalElapsed;
        /// <summary>
        /// Event raised when IsTicking state changed.
        /// </summary>
        public event TickingStateChangedHandler OnTickingStateChanged;

        private void TimerTask(object state)
        {
            if (IsTicking)
            {
                currentTime = DateTime.Now;
                TimeElapsed = currentTime - startTime;
                OnIntervalElapsed?.Invoke(this);
            }
        }

        private int StartingTime(int interval)
        {
            int start = interval;
            int offset = DateTime.Now.Millisecond;
            if(start < offset)
            {
                return 1;
            }
            else
            {
                return start - offset;
            }
        }
    }
}
