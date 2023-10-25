﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Abstarct
{
    public interface IBrandDal
    {
        int GetByID(Brand brand);
        List<Brand> GetAll();
        void Add(Brand brand);
        Brand Update(Brand brand);
        void Delete(Brand brand);
    }
}
