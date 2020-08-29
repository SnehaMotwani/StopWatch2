using System;
using System.Collections.Generic;
using System.Text;


namespace StopWatch2
{
    public class StopWatch
    {
        DateTime StartTime
        {
            get;
            set;
        }
        DateTime EndTime
        {
            get;
            set;
        }
        bool CheckIfStarted
        {
            get;
            set;
        }

        public void Start()
        {
            if (!CheckIfStarted)
            {
                StartTime = DateTime.Now;
                CheckIfStarted = true;
            }
        }
        public void Stop()
        {
            if (CheckIfStarted)
            {
                EndTime = DateTime.Now;
                CheckIfStarted = false;
            }
        }
        public TimeSpan TimeInterval()
        {
            return EndTime - StartTime;
        }
    }
}
