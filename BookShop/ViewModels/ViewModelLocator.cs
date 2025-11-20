using Microsoft.Extensions.DependencyInjection;

namespace BookShop.ViewModels
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => MyApp.Services.GetRequiredService<MainWindowViewModel>();
    }
}
