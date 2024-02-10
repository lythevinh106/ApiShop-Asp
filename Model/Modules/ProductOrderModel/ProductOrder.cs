using Model.Contracts;
using Model.Modules.OrderModel;
using Model.Modules.ProductModel;

namespace Model.Modules.ProductOrderModel
{
    public class ProductOrder : ISeedable, ICRUDTable
    {




        public string ProductId { get; set; }
        public string OrderId { get; set; }

        public int Quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }





        System.Collections.IList ISeedable.Seed()
        {
            var pOrders = new List<ProductOrder>(
             SeedGuid.ListGuid.Select(idx => new ProductOrder
             {
                 ProductId = idx,
                 OrderId = idx,
                 Quantity = new Random().Next(1, 50),


             })

              );
            return pOrders;

        }


    }

}
