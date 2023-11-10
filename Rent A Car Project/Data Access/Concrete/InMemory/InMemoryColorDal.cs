using Core.DataAccess;
using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> colors;

        public InMemoryColorDal()
        {
            colors = new List<Color>
            {
                new Color{Id = 1, ColorName = "Beyaz"},
                new Color{Id = 2, ColorName = "Siyah"},
                new Color{Id = 3, ColorName = "Kırmızı"},
                new Color{Id = 4, ColorName = "Mavi"},
                new Color{Id = 5, ColorName = "Kahverengi"},
                new Color{Id = 6, ColorName = "Sedefli Beyaz"},
                new Color{Id = 7, ColorName = "Mat Siyah"},
                new Color{Id = 8, ColorName = "Lacivert"},
                new Color{Id = 9, ColorName = "Turuncu"},
                new Color{Id = 10, ColorName = "Gri"}
            };
        }

        public void Add(Color color)
        {
            colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorOfDelete = colors.SingleOrDefault(c => c.Id == color.Id);

            if (colorOfDelete != null) colors.Remove(colorOfDelete);
        }

        public List<Color> GetAll()
        {
            return colors;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public int GetByID(Color color)
        {
            Color colorOfGetById = colors.SingleOrDefault(c => c.Id == color.Id);
            
            int ColorID = colorOfGetById.Id;
           
            return ColorID;
        }

        public Color Update(Color color)
        {
            Color colorOfDefault = colors.SingleOrDefault(c => c.Id == color.Id);
           
            colorOfDefault.Id = color.Id;

            colorOfDefault.ColorName = color.ColorName;

            return colorOfDefault;

        }

        void IEntityRepository<Color>.Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
