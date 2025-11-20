using BookShop.Services;
using BookShop.ViewModels;
using BookShop.Views.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace BookShop
{
    public class MyApp : Application
    {
        readonly MainWindow mainWindow;

        private static IHost host;

        public static IHost Host => host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        // через систему внедрения зависимостей получаем объект главного окна
        public MyApp()
        {
            mainWindow = new MainWindow();
        }
        public static IServiceProvider Services => Host.Services;

        public static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .AddServices()
            .AddViewModels()
            ;

        protected override async void OnStartup(StartupEventArgs e)
        {
            mainWindow.Show();  // открываем главное окно на экране
            using var host = Host;
            base.OnStartup(e);
            await host.StartAsync();
        }

        protected async void OnExit(ExitEventArgs e)
        {
            mainWindow.Close();  // закрываем главное окно на экране
            using var host = Host;
            base.OnExit(e);
            await host.StopAsync();
        }

    }
}
