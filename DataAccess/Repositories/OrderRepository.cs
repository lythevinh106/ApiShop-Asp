using Model;
using Model.Modules.OrderModel;

namespace DataAccess.Repositories
{
    public class OrderRepository : GenericReoponsitory<Order>
    {
        public OrderRepository(DBApiContext context) : base(context)
        {
        }
    }
}
