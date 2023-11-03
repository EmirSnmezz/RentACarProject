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
    public class efCarDal : ICarDal
    {
        RentACarContext _context;

        public efCarDal(RentACarContext context)
        {
            _context = context;
        }
        public void Add(Car entity)
        {
            using (_context)
            {
               
                var addedEntity = _context.Entry( entity );
                addedEntity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (_context)
            {
                var deletedEntity = _context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _context.Set<Car>().SingleOrDefault(filter);
        }

        public List<Car> GetAll(Expression <Func<Car,bool>> filter = null)
        {
            
                return filter==null ? _context.Set<Car>().ToList() : _context.Set<Car>().Where(filter).ToList();
            
        }

        public List<Car> GetByBranId(int BrandId)
        {
            return _context.Set<Car>().Where(p => p.BrandId == BrandId).ToList();
        }

        public List<Car> GetByColorId(int ColorId)
        {
            return _context.Set<Car>().Where(p => p.ColorId == ColorId).ToList();
        }

        public void Update(Car entity)
        {
            var updatedEntity = _context.Entry( entity );
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges ();
        }
    }
}
