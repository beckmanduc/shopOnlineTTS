using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig>
    {

    }
    public class SystemConfigRepository : RepositoryBase<SystemConfig>,ISystemConfigRepository
    {
        public SystemConfigRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
