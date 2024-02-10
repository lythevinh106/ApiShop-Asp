using DtoShared.Enums;
using Model.Contracts;
using Model.Modules.ProductOrderModel;
using Model.Modules.UserModel;

namespace Model.Modules.OrderModel
{
    public class Order : ISeedable, ICRUDTable
    {
        public string Id { get; set; } = new Guid().ToString();



        public StatusOrder Status { get; set; } = StatusOrder.Pending;

        public string UserId { get; set; }

        public virtual List<ProductOrder> ProductOrders { get; set; }

        public virtual User User { get; set; }

        System.Collections.IList ISeedable.Seed()
        {
            var orders = new List<Order>(
                 SeedGuid.ListGuid.Select(idx => new Order
                 {
                     Id = idx,
                     Status = StatusOrder.Pending,
                     UserId = idx,

                 })

              );
            return orders;
        }
    }
}
