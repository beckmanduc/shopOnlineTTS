using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {

    }
    public class FooterRepository : RepositoryBase<Footer>,IFooterRepository
    {
        public FooterRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
