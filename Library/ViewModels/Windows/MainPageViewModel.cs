using Library.Commands.Main;
using LibraryCore.Domain.Abstract;
using System.Windows.Controls;

namespace Library.ViewModels.Windows
{
    internal class MainPageViewModel
    {
        public MainPageViewModel(IUnitOfWork unitOfWork)
        {
            OpenGenres = new OpenGenresCommand(unitOfWork);
        }
        public OpenGenresCommand OpenGenres { get; }

        public Grid? grdCenter { get; set; }
    }
}
