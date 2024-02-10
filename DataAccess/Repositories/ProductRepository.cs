using Model;
using Model.Modules.ProductModel;

namespace DataAccess.Repositories
{
    public class ProductRepository : GenericReoponsitory<Product>
    {
        public ProductRepository(DBApiContext context) : base(context)
        {
        }
    }
}
