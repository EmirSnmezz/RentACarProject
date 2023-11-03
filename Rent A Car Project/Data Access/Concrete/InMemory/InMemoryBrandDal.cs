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
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> brands;

        public InMemoryBrandDal()
        {
            brands = new List<Brand>
            {
                new Brand{Id = 1 , BrandName = "Fiat"},
                new Brand{Id = 2 , BrandName = "Toyota"},
                new Brand{Id = 3 , BrandName = "Skoda"},
                new Brand{Id = 4 , BrandName = "BMW"},
                new Brand{Id = 5 , BrandName = "AUDİ"}
            };
        }
        public void Add(Brand brand)
        {
            brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandOfDelete = brands.SingleOrDefault(b => b.Id == brand.Id);
            
            brands.Remove(brandOfDelete);
        }


        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return brands;
        }

        public int GetById(Brand brand)
        {
            int brandId;
            Brand brandOfGetID = brands.SingleOrDefault(b=> b.Id == brand.Id);

            brandId = brandOfGetID.Id;

            return brandId;
        }

        public Brand Update(Brand brand)
        {
            Brand brandOfUpdate = brands.SingleOrDefault(b=> b.Id == brand.Id);

            brandOfUpdate.Id = brand.Id;

            brandOfUpdate.BrandName = brand.BrandName;

            return brandOfUpdate;
        }

        void IEntityRepository<Brand>.Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
