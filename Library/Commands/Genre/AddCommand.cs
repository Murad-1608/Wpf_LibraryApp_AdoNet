using Library.Enums;
using Library.ViewModels.Controls;

namespace Library.Commands.Genre
{
    public class AddCommand : BaseCommand
    {
        private readonly GenreViewModel viewModel;

        public AddCommand(GenreViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            viewModel.CurrentSituation = Situation.CREATE;
        }
    }
}
