using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Core;

namespace LayoutTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e)
        {
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();

            var mainWindow1 = new MainWindow();
            mainWindow1.Title = "Without SnapsToDevicePixel";
            mainWindow1.Show();

            var mainWindow2 = new MainWindow();
            mainWindow2.Title = "With SnapsToDevicePixel";
            mainWindow2.SnapsToDevicePixels = true;
            mainWindow2.Show();
        }
    }
}
