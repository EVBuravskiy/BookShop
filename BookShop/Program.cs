using Microsoft.Extensions.Hosting;

namespace BookShop
{
    public class Program
    {
        private static MyApp application { get; set; }

        // Entry point method
        [STAThread]
        public static void Main()
        {
            application = new MyApp();
            application.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(MyApp.ConfigureServices);
    }
}
