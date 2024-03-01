using Model;
using Model.Modules.ProductOrderModel;

namespace DataAccess.Repositories
{
    public class ProductOrderRepository : GenericReoponsitory<ProductOrder>
    {
        public ProductOrderRepository(DBApiContext context) : base(context)
        {
        }

        public async Task<ProductOrder> GetProductOrderByID(string productId, string orderId)
        {
            ProductOrder productOrder = await _context.FindAsync<ProductOrder>(productId, orderId);
            return productOrder;
        }
    }
}
