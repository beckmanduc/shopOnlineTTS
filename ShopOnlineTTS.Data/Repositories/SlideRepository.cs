using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface ISlideRepository
    {

    }
    public class SlideRepository : RepositoryBase<Slide>,ISlideRepository
    {
        public SlideRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
