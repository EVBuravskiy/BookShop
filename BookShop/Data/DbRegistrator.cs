using BookShop.DB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookShop.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration) => services
            .AddDbContext<BookShopDB>(opt =>
            {
                var type = configuration["Type"];
                switch (type)
                {
                    case "MSSQL": 
                        opt.UseSqlServer(configuration.GetConnectionString(type));
                        break;
                    case "SQLite":
                        opt.UseSqlite(configuration.GetConnectionString(type));
                        break;
                    case "InMemory":
                        opt.UseInMemoryDatabase("Bookshop.db");
                        break;
                    case null: throw new InvalidOperationException("Не определен тип базы данных");
                    default: throw new InvalidOperationException($"Тип подключения {type} не поддерживается");
                }
            });    
    }
}
