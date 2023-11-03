using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Entities.Concrete.Color;

namespace Data_Access.Abstarct
{
    public interface IColorDal : IEntityRepository <Color>
    {
    }
}
