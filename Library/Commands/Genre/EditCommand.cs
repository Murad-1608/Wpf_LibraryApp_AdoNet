﻿using Library.Enums;
using Library.ViewModels.Controls;

namespace Library.Commands.Genre
{
    public class EditCommand : BaseCommand
    {
        private readonly GenreViewModel viewModel;
        public EditCommand(GenreViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public override void Execute(object? parameter)
        {
            viewModel.CurrentSituation = Situation.EDIT;
        }
    }
}
