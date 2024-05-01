using Library.ViewModels.Controls;
using Library.ViewModels.Windows;
using Library.Views.Controls;
using LibraryCore.Domain.Abstract;
using System.Windows.Controls;
using System.Windows.Input;

namespace Library.Commands.Main
{
    internal class OpenGenresCommand : BaseCommand
    {
        private readonly IUnitOfWork unitOfWork;
        public OpenGenresCommand(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public override void Execute(object? parameter)
        {
            Grid? grid = parameter as Grid;

            if (grid == null)
                return;

            GenresControl genresControl = new();
            var genreViewModel = new GenreViewModel();

            genresControl.DataContext = genreViewModel;
            var genres = unitOfWork.GenreRepository.GetAll();



            grid.Children.Clear();
            grid.Children.Add(genresControl);


        }
    }
}
