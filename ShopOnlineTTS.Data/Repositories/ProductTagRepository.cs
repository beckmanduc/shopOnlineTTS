using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IProductTagRepository
    {

    }
    public class ProductTagRepository : RepositoryBase<ProductTag>,IProductTagRepository
    {
        public ProductTagRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
