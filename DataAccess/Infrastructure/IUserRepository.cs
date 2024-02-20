using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using Model.Modules.UserModel;
using System.Linq.Expressions;

namespace DataAccess.Infrastructure
{
    public interface IUserRepository
    {
        Task<IQueryable<User>> All();

        Task<PagedList<User>> FectchData(FetchDataRequest fetchDataRequest, IQueryable<User> query);

        Task<User> Add(RegisterUser registerUser);

        IQueryable<User> Sort(Expression<Func<User, string>> field, IQueryable<User> query, bool ascending = true);

        public Task<bool> CheckExist(Expression<Func<User, bool>> predicate);

        Task<User> Get(string id);

        Task<User> Delete(User user);

        Task<User> Update(User user);

        Task<List<User>> Find(Expression<Func<User, bool>> predicate);

        //T Delete(T entity);
    }
}