using Model.Contracts;
using Model.Modules.ProductModel;
using System.Collections;

namespace Model.Modules.PromotionModel
{
    public class Promotion : ISeedable, ICRUDTable
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value > 100)
                {
                    _value = 100;
                }
                else if (value < 0)
                {
                    _value = 0;
                }
                else
                {
                    _value = value;
                }
            }



        }
        public DateTime Time { get; set; } = DateTime.Now;
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public virtual List<Product> Products { get; set; }



        public IList Seed()
        {
            var promotions = new List<Promotion>(
            SeedGuid.ListGuid.Select(idx => new Promotion
            {
                Id = idx,
                Name = $"PromotionName {new Random().Next(1, 50)}",

                Description = "Mô tả điện thoại",
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now,
                _value = new Random().Next(1, 50)

            })

              );
            return promotions;
        }
    }
}
