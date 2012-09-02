using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The3Mus.XProjectTimeTracker.DataLayer
{
    public class TimeEntry : XProjectTimeTrackingObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private DateTime begin;

        public DateTime Begin
        {
            get { return begin; }
            set { begin = value; }
        }
        private DateTime end;

        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
    }
}
