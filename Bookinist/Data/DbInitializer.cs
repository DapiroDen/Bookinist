using Bookinist.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist.Data
{
    class DbInitializer
    {
        private readonly BookinistDb _db;
        private readonly ILogger<DbInitializer> _logger;

        public DbInitializer(BookinistDb db, ILogger<DbInitializer> logger)
        {
            _db = db;
            _logger = logger;
        }

        public async Task InitializeAsync() 
        {
            await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);

            await _db.Database.MigrateAsync();

            if (await _db.Books.AnyAsync()) return;

        }

        private const int _CategoriesCount = 10;

        private async Task InitialzeCategories()
        {

        }

        private async Task InitialzeBooks()
        {

        }
    }
}
