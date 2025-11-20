using MathCore.WPF.ViewModels;

namespace BookShop.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private string title = "Главное окно програмы";
        public string Title
        {
            get => title;
            set
            {
                title = value;
            }
        }
    }
}
