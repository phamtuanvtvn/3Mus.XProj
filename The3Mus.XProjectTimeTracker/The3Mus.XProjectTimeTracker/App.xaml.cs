using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace The3Mus.XProjectTimeTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static PageLogin pageLogin = null;
        private static PageSignUp pageSignUp = null;
        private static PageProjects pageProjects = null;

        public static PageLogin PageLogin
        {
            get
            {
                if (pageLogin == null)
                {
                    pageLogin = new PageLogin();
                }

                return pageLogin;
            }
        }

        public static PageSignUp PageSignUp
        {
            get
            {
                if (pageSignUp == null)
                {
                    pageSignUp = new PageSignUp();
                }

                return pageSignUp;
            }
        }

        public static PageProjects PageProjects
        {
            get
            {
                if (pageProjects == null)
                {
                    pageProjects = new PageProjects();
                }

                return pageProjects;
            }
        }
    }
}
