using Model.Contracts;
using Model.Modules.CategoryModel;
using Model.Modules.ProductOrderModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Modules.ProductModel
{
    public class Product : ISeedable, ICRUDTable
    {

        public string Id { get; set; } = new Guid().ToString();

        [StringLength(500)]
        public string Name { get; set; }


        [Range(0, double.MaxValue)]

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }


        public virtual List<ProductOrder> ProductOrders { get; set; }
        System.Collections.IList ISeedable.Seed()
        {
            var products = new List<Product>(
             SeedGuid.ListGuid.Select(idx => new Product
             {
                 Id = idx,
                 Name = $"ProductName {new Random().Next(1, 50)}",
                 Image = "https://blob3tier.blob.core.windows.net/azureblobwith3tier/samurai.png%2B6775e8b2-a9ab-4792-afcd-202adae206f8",
                 Price = 2536 + new Random().Next(1, 50),
                 CategoryId = idx,
                 Description = "Mô tả điện thoại"

             })

               );
            return products;
        }


    }
}
