using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MultiLangTest.Resources;
using System.Threading;
using System.IO.IsolatedStorage;

namespace MultiLangTest
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Initializing settings parameters in isolated storage
        // These user settings will be saved in Onedrive & will be restored when the app will be
        // intalled on different (or same) devices.
        IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Changing language culture & pass it to App.xaml.cs for intializing on next startup
        private void goHindi(object sender, EventArgs e)
        {
            settings["Language"] = "hi-IN";
            MessageBox.Show("Restart the App");
        }

        private void goEnglish(object sender, EventArgs e)
        {
            settings["Language"] = "en-US";
            MessageBox.Show("Restart the App");
        }
    }
}