using Bookinist.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist.Data
{
    static class DbRegistator
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration configuration) => services
            .AddDbContext<BookinistDb>(opt =>
            {
                var type = configuration["Type"];
                switch (type)
                {
                    case null: throw new InvalidOperationException($"Не определён тип базы данных");
                    default: throw new InvalidOperationException($"Тип подключения {type} не поддерживается");
                    case "MSSQL":
                        opt.UseSqlServer(configuration.GetConnectionString(type));
                        break;
                    case "MSLite":
                        opt.UseSqlite(configuration.GetConnectionString(type));
                            break;
                    case "InMemory":
                        opt.UseInMemoryDatabase("Bookinist.db");
                        break;
                }
            });
    }
}
