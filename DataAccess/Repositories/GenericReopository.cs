﻿using DataAccess.Infrastructure;
using DtoShared.FetchData;
using DtoShared.Pagging;
using Microsoft.EntityFrameworkCore;
using Model;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    public abstract class GenericReoponsitory<T> : IRepository<T> where T : class
    {
        protected DBApiContext _context;

        public GenericReoponsitory(DBApiContext context)
        {
            _context = context;
        }

        public virtual async Task<T> Add(T entity)
        {
            var result = await _context.AddAsync(entity);
            return result.Entity;
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }



        public virtual IQueryable<T> All()
        {
            return _context.Set<T>();
        }

        public virtual async Task<T> Get(string id)
        {
            return await _context.FindAsync<T>(id);
        }

        public virtual T Update(T entity)
        {
            return _context.Update<T>(entity).Entity;
        }

        public PagedList<T> FectchData(FetchDataRequest fetchDataRequest, IQueryable<T> query)
        {


            return PagedList<T>
                .ToPagedList(query, fetchDataRequest.PageNumber, fetchDataRequest.PageSize);
        }




        //public IQueryable<T> Filter(Expression<Func<T, bool>> predicate, IQueryable<T> query)
        //{
        //    return query.Where(predicate);
        //}

        public IOrderedQueryable<T> Sort<Tkey>(Expression<Func<T, Tkey>> field, IQueryable<T> query, bool ascending = true)
        {
            if (ascending) return query.OrderByDescending(field);


            return query.OrderBy(field);
        }

        public IOrderedQueryable<T> SortThenBy<Tkey>(Expression<Func<T, Tkey>> field, IOrderedQueryable<T> query, bool ascending = true)
        {
            if (ascending) return query.ThenByDescending(field);


            return query.ThenBy(field);
        }



        //public IQueryable<T> Search(Expression<Func<T, bool>> predicate, IQueryable<T> query)
        //{


        //    return query.Where(predicate);
        //}


        public async Task<bool> CheckExist(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AnyAsync(predicate);
        }

        public T Delete(T entity)
        {
            return _context.Set<T>().Remove(entity).Entity;
        }


    }
}
