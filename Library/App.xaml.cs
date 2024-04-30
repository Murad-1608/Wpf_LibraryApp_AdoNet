using Library.Views.Windows;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            MainPage mainPage = new();

            mainPage.Show();
        }
    }

}
