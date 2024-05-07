using Library.ViewModels.Windows;
using Library.Views.Windows;
using LibraryCore.DataAccess.MsSql.AdoNet;
using LibraryCore.Domain.Abstract;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Threading;

namespace Library
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Dispatcher.UnhandledException += OnUnHandledException;
            IUnitOfWork unitOfWork = new SqlUnitOfWork();

            MainPageViewModel viewModel = new(unitOfWork);
            MainPage mainPage = new();

            mainPage.DataContext = viewModel;
            mainPage.Show();
        }

        private void OnUnHandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;

            MessageBox.Show("Something went wrong, please try again");
        }
    }

}
