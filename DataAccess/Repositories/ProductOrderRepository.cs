using Model;
using Model.Modules.ProductOrderModel;

namespace DataAccess.Repositories
{
    public class ProductOrderRepository : GenericReoponsitory<ProductOrder>
    {
        public ProductOrderRepository(DBApiContext context) : base(context)
        {
        }
    }
}
