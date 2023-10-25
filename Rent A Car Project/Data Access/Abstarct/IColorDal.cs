using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Abstarct
{
    public interface IColorDal
    {
        int GetByID(Color color);
        List<Color> GetAll();
        void Add(Color colors);
        Color Update(Color color);
        void Delete(Color color);
    }
}
