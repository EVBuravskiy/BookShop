using MathCore.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.ViewModels
{
    internal class MainWindowViewModel : ViewModel
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
