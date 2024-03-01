using Model;
using Model.Modules.OrderModel;

namespace DataAccess.Repositories
{
    public class OrderRepository : GenericReoponsitory<Order>
    {
        public OrderRepository(DBApiContext context) : base(context)
        {
        }

        //public async Task<CountOrderInfo> ShowCountOrderInfo(IQueryable queryable)
        //{

        //    return new CountOrderInfo()
        //    {


        //        dailyProfit = 3,
        //        dailySoldNumber = 3,
        //        monthlyProfit = 3,
        //        monthlySoldNumber = 3
        //    };
        //}


    }
}
