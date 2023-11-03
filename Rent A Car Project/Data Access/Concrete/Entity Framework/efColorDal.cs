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
    public class efColorDal : IColorDal
    {
        RentACarContext _context;
        public efColorDal(RentACarContext context) 
        {
            _context = context; 
        }

        public void Add(Color entity)
        {
            using( _context )
            {
                var addedEntity = _context.Entry(entity);
                addedEntity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (_context)
            {
                var deletedEntity = _context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }


        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return filter == null ? _context.Set <Color>().ToList() : _context.Set <Color>().Where(filter).ToList();
        }

        public Color GetByID(Expression<Func<Color, bool>> filter)
        {
            return (Color) _context.Set<Color>().Where(filter) ;
        }

        public void Update(Color entity)
        {
            using (_context)
            {
                var updatedEntity = _context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
