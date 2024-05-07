using Library.Enums;
using Library.ViewModels.Controls;

namespace Library.Commands.Genre
{
    public class DeleteCommand : BaseCommand
    {
        private readonly GenreViewModel viewModel;

        public DeleteCommand(GenreViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public override void Execute(object? parameter)
        {
            viewModel.CurrentSituation = Situation.NORMAL;
        }
    }
}
