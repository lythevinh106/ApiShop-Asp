using DtoShared.FetchData;
using DtoShared.Pagging;
using System.Linq.Expressions;

namespace DataAccess.Infrastructure
{
    public interface IRepository<T>
    {


        public Task<bool> CheckExist(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);

        T Update(T entity);

        Task<T> Get(string id);

        T Delete(T entity);
        IQueryable<T> All();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);


        PagedList<T> FectchData(FetchDataRequest fetchDataRequest, IQueryable<T> query);




        IOrderedQueryable<T> Sort<Tkey>(Expression<Func<T, Tkey>> field, IQueryable<T> query, bool ascending = true);
        IOrderedQueryable<T> SortThenBy<Tkey>(Expression<Func<T, Tkey>> field, IOrderedQueryable<T> query, bool ascending = true);


        //IQueryable<T> Filter(Expression<Func<T, bool>> predicate, IQueryable<T> query);
        // IQueryable<T> Search(Expression<Func<T, bool>> predicate, IQueryable<T> query);

    }
}
