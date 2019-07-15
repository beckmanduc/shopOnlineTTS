using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IOrderDetailRepository
    {

    }
    public class OrderDetailRepository : RepositoryBase<OrderDetail>,IOrderDetailRepository
    {
        public OrderDetailRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
