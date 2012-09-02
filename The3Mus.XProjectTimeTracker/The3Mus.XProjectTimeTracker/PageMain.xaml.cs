using System.Windows;
using System.Windows.Controls;

namespace The3Mus.XProjectTimeTracker
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        #region Event Handlers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonButton_Clicked(object sender, RoutedEventArgs e)
        {
            #region Common Treament
            // TODO : common treament
            #endregion Common Treament

            #region Specific Treament
            if (sender == btnLogin)
            {
                btnLogin_Click(sender, e);
            }
            else if (sender == btnSignUp)
            {
                btnSignUp_Click(sender, e);
            }
            #endregion Specific Treament
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(App.PageLogin);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(App.PageSignUp);
        }

        #endregion Event Handlers
    }
}