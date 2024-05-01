using Library.ViewModels.Windows;
using Library.Views.Windows;
using LibraryCore.DataAccess.MsSql.AdoNet;
using LibraryCore.Domain.Abstract;
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
            IUnitOfWork unitOfWork = new SqlUnitOfWork();

            MainPageViewModel viewModel = new(unitOfWork);
            MainPage mainPage = new();

            mainPage.DataContext = viewModel;
            mainPage.Show();
        }
    }

}
