using BookShop.ViewModels;
using System.Windows;


namespace BookShop.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModelLocator ViewModelLocator { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModelLocator = new ViewModelLocator();
            DataContext = ViewModelLocator.MainWindowViewModel;
            
        }
    }
}
