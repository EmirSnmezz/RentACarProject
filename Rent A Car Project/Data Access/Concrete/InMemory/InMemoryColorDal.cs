using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.InMemory
{
    public class InMemoryColorDal:IColorDal
    {
        List<Color> colors;

        public InMemoryColorDal()
        {
            colors = new List<Color>
            {
                new Color{ID = 1, ColorName = "Beyaz"},
                new Color{ID = 2, ColorName = "Siyah"},
                new Color{ID = 3, ColorName = "Kırmızı"},
                new Color{ID = 4, ColorName = "Mavi"},
                new Color{ID = 5, ColorName = "Kahverengi"},
                new Color{ID = 6, ColorName = "Sedefli Beyaz"},
                new Color{ID = 7, ColorName = "Mat Siyah"},
                new Color{ID = 8, ColorName = "Lacivert"},
                new Color{ID = 9, ColorName = "Turuncu"},
                new Color{ID = 10, ColorName = "Gri"}
            };
        }

        public void Add(Color color)
        {
            colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorOfDelete = colors.SingleOrDefault(c => c.ID == color.ID);

            if (colorOfDelete != null) colors.Remove(colorOfDelete);
        }

        public List<Color> GetAll()
        {
            return colors;
        }

        public int GetByID(Color color)
        {
            Color colorOfGetById = colors.SingleOrDefault(c => c.ID == color.ID);
            
            int ColorID = colorOfGetById.ID;
           
            return ColorID;
        }

        public Color Update(Color color)
        {
            Color colorOfDefault = colors.SingleOrDefault(c => c.ID == color.ID);
           
            colorOfDefault.ID = color.ID;

            colorOfDefault.ColorName = color.ColorName;

            return colorOfDefault;

        }
    }
}
