using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The3Mus.XProjectTimeTracker.DataLayer
{
    public abstract class XProjectTimeTrackingObject : IXProjectTimeTrackingObject
    {
        protected long id;

        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }
    }
}
