using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopOnlineTTSDbContext dbContext;

        public ShopOnlineTTSDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopOnlineTTSDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
