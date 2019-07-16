using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {

    }
    public class PostRepository : RepositoryBase<Post>,IPostRepository
    {
        public PostRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
