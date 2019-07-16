using ShopOnlineTTS.Data.Infrastructure;
using ShopOnlineTTS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineTTS.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {

    }
    public class OrderRepository : RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
