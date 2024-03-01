using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Contracts;
using Model.Modules.CategoryModel;
using Model.Modules.OrderModel;
using Model.Modules.ProductModel;
using Model.Modules.ProductOrderModel;
using Model.Modules.PromotionModel;
using Model.Modules.UserModel;

namespace Model
{
    public class DBApiContext : IdentityDbContext<User>
    {
        public DBApiContext(DbContextOptions<DBApiContext> options) : base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductOrder> ProductOrders { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Promotion> Promotions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasMany(c => c.Products).WithOne(p => p.Category);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);

                //relative category
                entity.HasOne(p => p.Category)
                .WithMany(p => p.Products).HasForeignKey(p => p.CategoryId);

                // relative producrOrder
                entity.HasMany(p => p.ProductOrders)
                .WithOne(po => po.Product);
            });

            modelBuilder.Entity<ProductOrder>(entity =>
            {
                entity.HasKey(po => new { po.ProductId, po.OrderId });

                entity.HasOne(po => po.Product)
                .WithMany(p => p.ProductOrders)
                .HasForeignKey(po => po.ProductId);

                entity.HasOne(po => po.Order)
               .WithMany(o => o.ProductOrders).HasForeignKey(po => po.OrderId);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);

                //relative user
                entity.HasOne(o => o.User)
                .WithMany(u => u.Orders).HasForeignKey(o => o.UserId);

                //relative product order
                entity.HasMany(o => o.ProductOrders)
                .WithOne(po => po.Order);
            });




            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasKey(pr => pr.Id);


                entity.HasMany(pr => pr.Products).WithOne(p => p.Promotion)
                .HasForeignKey(p => p.PromotionId);


            });





            ///seed

            var entities = typeof(ISeedable).Assembly.GetTypes().Where(x => typeof(ISeedable).IsAssignableFrom(x))
                                .Where(x => !x.IsInterface).ToList();

            foreach (var m in entities)
            {
                var entity = modelBuilder.Entity(m);

                Console.WriteLine(m);

                if (typeof(ISeedable).IsAssignableFrom(m))
                {
                    var inst = Activator.CreateInstance(m) as ISeedable;
                    var data = inst?.Seed();

                    foreach (var d in data)
                        entity.HasData(d);
                }
            }



        }

    }
}
