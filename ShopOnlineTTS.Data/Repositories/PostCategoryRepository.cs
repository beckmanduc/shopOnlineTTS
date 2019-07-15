using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IPostCategoryRepository
    {

    }
    public class PostCategoryRepository : RepositoryBase<Post>,IPostCategoryRepository
    {
        public PostCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
