using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MenuGroup>
    {

    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>,IMenuGroupRepository
    {
        public MenuGroupRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
