using Business.Abstract;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _color;

        public ColorManager(IColorDal color) 
        { 
            _color = color;
        }

        public void Add(Color entity)
        {
            _color.Add(entity);
        }

        public void Delete(Color entity)
        {
            _color.Delete(entity);
        }

        public List<Color> GetAll()
        {
           return _color.GetAll(); 
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            if(filter != null)
            {
            return _color.GetAll(filter);
            }

            return _color.GetAll();
           
        }

        public void Update(Color entity)
        {
            _color.Update(entity);
        }
    }
}
