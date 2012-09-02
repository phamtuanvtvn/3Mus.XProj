using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The3Mus.XProjectTimeTracker.DataLayer
{
    public class User : XProjectTimeTrackingObject
    {
        private UserGeneralInfos userGeneralInfos;
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserGeneralInfos UserGeneralInfos
        {
            get
            {
                return this.userGeneralInfos;
            }
            set
            {
                this.userGeneralInfos = value;
            }
        }

        private List<Project> projects;

        public List<Project> Projects
        {
            get { return projects; }
            set { projects = value; }
        }
    }
}
