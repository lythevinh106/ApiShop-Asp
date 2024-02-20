using Model;
using Model.Modules.CategoryModel;

namespace DataAccess.Repositories
{
    public class CategoryRepository : GenericReoponsitory<Category>
    {
        public CategoryRepository(DBApiContext context) : base(context)
        {
        }


    }
}
