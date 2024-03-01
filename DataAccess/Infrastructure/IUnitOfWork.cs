using DataAccess.Repositories;
using Model;

namespace DataAccess.Infrastructure
{
    public interface IUnitOfWork
    {

        ProductRepository ProductReponsitory { get; }

        CategoryRepository CategoryRepository { get; }
        OrderRepository OrderRepository { get; }
        ProductOrderRepository ProductOrderRepository { get; }
        PromotionRepository PromotionRepository { get; }



        void SaveChanges();

    }
    public class UnitOfWork : IUnitOfWork
    {



        private DBApiContext _context;

        public UnitOfWork(DBApiContext context)
        {
            _context = context;

        }


        private ProductRepository productRepository;

        public ProductRepository ProductReponsitory
        {


            get
            {
                return productRepository ?? new ProductRepository(_context);
            }
        }

        public CategoryRepository categoryRepository;

        public CategoryRepository CategoryRepository
        {
            get
            {
                return categoryRepository ?? new CategoryRepository(_context);
            }

        }


        public OrderRepository orderRepository;

        public OrderRepository OrderRepository
        {
            get
            {
                return orderRepository ?? new OrderRepository(_context);
            }

        }


        public ProductOrderRepository productOrderRepository;

        public ProductOrderRepository ProductOrderRepository
        {
            get
            {
                return productOrderRepository ?? new ProductOrderRepository(_context);
            }

        }


        public PromotionRepository promotionRepository;

        public PromotionRepository PromotionRepository
        {
            get
            {
                return promotionRepository ?? new PromotionRepository(_context);
            }

        }






        public void SaveChanges()
        {
            _context.SaveChanges();

        }
    }

}
