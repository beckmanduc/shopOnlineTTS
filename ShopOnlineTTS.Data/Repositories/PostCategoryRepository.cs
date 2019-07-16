using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {

    }
    public class PostCategoryRepository : RepositoryBase<PostCategory>,IPostCategoryRepository
    {
        public PostCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
