using Microsoft.Extensions.DependencyInjection;

namespace BookShop.ViewModels
{
    static public class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>()
        ;
    }
}
