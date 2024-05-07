using LibraryCore.Domain.Abstract;

namespace Library.ViewModels.Controls
{
    public class BaseControlViewModel : BaseViewModel
    {
        internal IUnitOfWork unitOfWork;
        public BaseControlViewModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
