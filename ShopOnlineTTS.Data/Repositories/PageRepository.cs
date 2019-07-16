using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {

    }
    public class PageRepository : RepositoryBase<Page>,IPageRepository
    {
        public PageRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
