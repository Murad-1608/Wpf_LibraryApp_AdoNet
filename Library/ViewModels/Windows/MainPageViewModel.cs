using Library.Commands.Main;
using System.Windows.Controls;

namespace Library.ViewModels.Windows
{
    internal class MainPageViewModel
    {
        public MainPageViewModel()
        {
            OpenGenresCommand = new OpenGenresCommand();
        }
        public OpenGenresCommand OpenGenresCommand { get; }

        public Grid grdCenter { get; set; }
    }
}
