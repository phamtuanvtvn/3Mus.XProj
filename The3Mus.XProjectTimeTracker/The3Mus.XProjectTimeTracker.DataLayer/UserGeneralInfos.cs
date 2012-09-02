using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The3Mus.XProjectTimeTracker.DataLayer
{
    public class UserGeneralInfos : XProjectTimeTrackingObject
    {
        private User user;

        public User User
        {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
            }
        }
    }
}
