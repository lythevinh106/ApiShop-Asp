using Model.Contracts;
using Model.Modules.ProductModel;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Model.Modules.CategoryModel
{
    public class Category : ISeedable, ICRUDTable
    {
        public string Id { get; set; } = new Guid().ToString();

        [StringLength(500)]
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }

        public IList Seed()
        {
            var categories = new List<Category>(

                SeedGuid.ListGuid.Select(idx => new Category
                {
                    Id = idx,
                    Name = $"category name  {new Random().Next(1, 50)}",
                })

               );

            return categories;
        }
    }
}
