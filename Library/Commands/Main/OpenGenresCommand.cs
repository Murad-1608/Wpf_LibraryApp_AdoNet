using Library.Mappers;
using Library.Models;
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

            var genreForUI = new List<GenreModel>();

            GenreMapper mapper = new GenreMapper();

            for (int i = 0; i < genres.Count; i++)
            {
                var genreModel = mapper.Map(genres[i]);
                genreModel.No = (i + 1);

                genreForUI.Add(genreModel);
            }

            genreViewModel.Genres = genreForUI;

            grid.Children.Clear();
            grid.Children.Add(genresControl);


        }
    }
}
