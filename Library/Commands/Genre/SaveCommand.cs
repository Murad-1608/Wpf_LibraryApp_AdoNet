using Library.Enums;
using Library.Mappers;
using Library.Models;
using Library.ViewModels.Controls;
using LibraryCore.Domain.Abstract;

namespace Library.Commands.Genre
{
    public class SaveCommand : BaseCommand
    {
        private readonly GenreViewModel viewModel;
        public SaveCommand(GenreViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public override void Execute(object? parameter)
        {
            GenreMapper mapper = new();

            var entity = mapper.Map(viewModel.CurrentGenre);
            entity.IsActive = true;
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            entity.ModifierId = 1000;

            viewModel.unitOfWork.GenreRepository.Add(entity);

            var lastElementNo= viewModel.Genres.LastOrDefault()?.No ?? 0;

            viewModel.CurrentGenre.No = lastElementNo + 1;

            viewModel.Genres.Add(viewModel.CurrentGenre);

            viewModel.CurrentGenre = new GenreModel();
            viewModel.CurrentSituation = Situation.NORMAL;
        }
    }
}
