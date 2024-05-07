using Library.Commands.Genre;
using Library.Enums;
using Library.Models;
using Library.ViewModels.Interfaces;
using LibraryCore.Domain.Abstract;
using System.Collections.ObjectModel;

namespace Library.ViewModels.Controls
{
    public class GenreViewModel : BaseControlViewModel, IControlViewModel
    {
        public GenreViewModel(IUnitOfWork unitOfWork):base(unitOfWork)
        {
            CurrentGenre = new GenreModel();
        }
        public AddCommand Add => new AddCommand(this);
        public EditCommand Edit => new EditCommand(this);
        public RejectCommand Reject => new RejectCommand(this);
        public SaveCommand Save => new SaveCommand(this);

        private Situation currentSituation;
        public Situation CurrentSituation
        {
            get => currentSituation;
            set
            {
                currentSituation = value;
                OnPropertyChanged(nameof(CurrentSituation));
            }
        }
        public ObservableCollection<GenreModel> Genres { get; set; }

        private GenreModel currentGenre;
        public GenreModel CurrentGenre
        {
            get
            {
                return currentGenre;
            }
            set
            {
                currentGenre = value;
                OnPropertyChanged(nameof(CurrentGenre));
            }
        }

        public string Header => "Genres";
    }
}
