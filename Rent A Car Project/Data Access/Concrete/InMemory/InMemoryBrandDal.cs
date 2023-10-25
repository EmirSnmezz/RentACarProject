using Data_Access.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> brands;

        public InMemoryBrandDal()
        {
            brands = new List<Brand>
            {
                new Brand{ID = 1 , BrandName = "Fiat"},
                new Brand{ID = 2 , BrandName = "Toyota"},
                new Brand{ID = 3 , BrandName = "Skoda"},
                new Brand{ID = 4 , BrandName = "BMW"},
                new Brand{ID = 5 , BrandName = "AUDİ"}
            };
        }
        public void Add(Brand brand)
        {
            brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandOfDelete = brands.SingleOrDefault(b => b.ID == brand.ID);
            
            brands.Remove(brandOfDelete);
        }

        public List<Brand> GetAll()
        {
            return brands;
        }

        public int GetByID(Brand brand)
        {
            int brandID;
            Brand brandOfGetID = brands.SingleOrDefault(b=> b.ID == brand.ID);

            brandID = brandOfGetID.ID;

            return brandID;
        }

        public Brand Update(Brand brand)
        {
            Brand brandOfUpdate = brands.SingleOrDefault(b=> b.ID == brand.ID);

            brandOfUpdate.ID = brand.ID;

            brandOfUpdate.BrandName = brand.BrandName;

            return brandOfUpdate;
        }
    }
}
