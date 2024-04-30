using Library.ViewModels.Windows;
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
            MainPageViewModel viewModel = new();
            MainPage mainPage = new();

            mainPage.DataContext = viewModel;
            mainPage.Show();
        }
    }

}
