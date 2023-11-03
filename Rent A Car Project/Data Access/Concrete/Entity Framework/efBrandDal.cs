using Data_Access.Abstarct;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.Entity_Framework
{
    public class efBrandDal : IBrandDal
    {
        RentACarContext _context;

        public efBrandDal(RentACarContext context)
        {
            _context = context;
        }


        public void Add(Brand entity)
        {
           using(_context)
            {
                var addedEntity = _context.Entry(entity);
                addedEntity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return filter == null ? _context.Set<Brand>().ToList() : _context.Set<Brand>().Where(filter).ToList();
        }

        public Brand GetByID(Expression<Func<Brand, bool>> filter)
        {
            return (Brand) _context.Set<Brand>().Where(filter);
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
