using Model;
using Model.Modules.PromotionModel;

namespace DataAccess.Repositories
{
    public class PromotionRepository : GenericReoponsitory<Promotion>
    {
        public PromotionRepository(DBApiContext context) : base(context)
        {
        }
    }
}
