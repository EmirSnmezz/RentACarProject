using Business.Abstract;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Color> GetAll()
        {
           return _color.GetAll(); 
        }
    }
}
