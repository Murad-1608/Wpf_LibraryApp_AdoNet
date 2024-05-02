using Library.Enums;
using Library.Models;

namespace Library.ViewModels.Controls
{
    public class GenreViewModel
    {
        public Stuation CurrentStuation { get; set; }
        public List<GenreModel> Genres { get; set; }
    }
}
