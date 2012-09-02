using System.Windows;
using System.Windows.Controls;
using The3Mus.XProjectTimeTracker.Services;

namespace The3Mus.XProjectTimeTracker
{
    /// <summary>
    /// Interaction logic for PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        private IDialogService dialogService;

        public PageLogin()
        {
            InitializeComponent();

            dialogService = new WPFDialogService();
        }

        #region Event Handlers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonButton_Clicked(object sender, RoutedEventArgs e)
        {
            #region Common treatment for all buttons
            // TODO: Common treatment for all buttons
            #endregion Common treatment for all buttons

            #region Specific treatment for each button            
            if (sender == this.btnLogin)
            {
                btnLogin_Clicked(sender, e);
            }
            else if (sender == this.btnCancel)
            {
                btnCancel_Clicked(sender, e);
            }
            #endregion Specific treatment for each button
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Clicked(object sender, RoutedEventArgs e)
        {
            // TODO : Validate data
            // TODO : Send login request
            // TODO : Navigate to "view projects" window if success
            if (true)
            {
                PageProjects pageProjects = new PageProjects();
                this.NavigationService.Navigate(pageProjects);
            }
            // TODO : Show error message if not success
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Clicked(object sender, RoutedEventArgs e)
        {
            // TODO : Navigate back to main window
            this.NavigationService.GoBack();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            #region Common treatment for all text boxes
            // TODO : Common treatment for all text boxes
            #endregion Common treatment for all text boxes

            #region Specific treatment for each text box
            // TODO : Specific treatment for each text box
            #endregion Specific treatment for each text box
        }

        #endregion Event Handlers
    }
}
