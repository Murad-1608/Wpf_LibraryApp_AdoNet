using Library.Commands.Genre;
using Library.Enums;
using Library.Models;
using Library.ViewModels.Interfaces;

namespace Library.ViewModels.Controls
{
    public class GenreViewModel : BaseViewModel, IControlViewModel
    {
        public GenreViewModel()
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
        public List<GenreModel> Genres { get; set; }
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
