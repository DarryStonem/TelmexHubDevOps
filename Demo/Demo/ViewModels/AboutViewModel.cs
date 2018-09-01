using System;
using System.Windows.Input;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace Demo.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            Analytics.TrackEvent("User enter to About Page");

            OpenWebCommand = new Command(CrashTheApp);
            CrashCommand = new Command(CrashTheAppNew);
        }

        private void CrashTheApp(object obj)
        {
            //throw new Exception("About crash");
        }

        private void CrashTheAppNew(object obj)
        {
            throw new Exception("About crash... again");
        }

        public ICommand OpenWebCommand { get; }
        public ICommand CrashCommand { get; }
    }
}