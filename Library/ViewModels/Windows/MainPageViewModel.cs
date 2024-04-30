using Library.Commands.Main;
using System.Windows.Controls;

namespace Library.ViewModels.Windows
{
    internal class MainPageViewModel
    {
        public MainPageViewModel()
        {
            OpenGenres = new OpenGenresCommand(this);
        }
        public OpenGenresCommand OpenGenres { get; }

        public Grid? grdCenter { get; set; }
    }
}
