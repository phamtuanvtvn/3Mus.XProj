using System;
using System.Windows;

namespace The3Mus.XProjectTimeTracker.Services
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class WPFDialogService : IDialogService
    {
        #region Implementation of IDialogService interface
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        void IDialogService.ShowInfo(string title, string message)
        {
            MessageBox.Show(title,
                message,
                MessageBoxButton.OK,
                MessageBoxImage.Exclamation);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        void IDialogService.ShowError(string title, string message)
        {
            MessageBox.Show(title,
                message,
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        void IDialogService.ShowAlert(string title, string message)
        {
            MessageBox.Show(title,
                message,
                MessageBoxButton.OK,
                MessageBoxImage.Asterisk);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        bool IDialogService.AskConfirmation(string title, string message)
        {
            MessageBoxResult dialogResult = MessageBox.Show(title,
                message,
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            return dialogResult == MessageBoxResult.Yes;
        }

        #endregion Implementation of IDialogService interface
    }
}
