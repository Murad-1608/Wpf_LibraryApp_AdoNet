using Library.ViewModels.Windows;
using Library.Views.Controls;
using System.Windows.Input;

namespace Library.Commands.Main
{
    internal class OpenGenresCommand : BaseCommand
    {
        private readonly MainPageViewModel viewModel;
        public OpenGenresCommand(MainPageViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public override void Execute(object? parameter)
        {
            viewModel.grdCenter.Children.Clear();

            GenresControl genresControl = new();

            viewModel.grdCenter.Children.Add(genresControl);
        }
    }
}
