using Business.Concrete;
using Data_Access.Abstarct;
using Data_Access.Concrete.Entity_Framework;
using Data_Access.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //Console.WriteLine("-------------------------------------------- ARABALAR / CARS -------------------------------------------------");

            //foreach ( var car in carManager.GetAll())
            //{

            //    Console.WriteLine(car.ID+":"+car.BranID+":"+car.ColorID+":"+car.Description);

            //}
            //Console.WriteLine("-------------------------------------------- RENKLER / COLORS -------------------------------------------------");
            //ColorManager colorManager = new ColorManager(new InMemoryColorDal());

            //foreach (var color in colorManager.GetAll())
            //{

            //    Console.WriteLine(color.ID+":"+color.ColorName);

            //}
            //Console.WriteLine("-------------------------------------------- MARKALAR / BRANDS -------------------------------------------------");
            //BrandManager brandManager = new BrandManager(new InMemoryBrandDal());

            //foreach (var brand in brandManager.GetAll())
            //{

            //    Console.WriteLine(brand.ID + ":" + brand.BrandName);

            //}
            RentACarContext _context = new RentACarContext();

            CarManager carManager = new CarManager(new efCarDal(_context));

            carManager.Add(new Car { ID = 1, BrandId = 1, ColorId = 1, DailyPrice = 3, Description = "2", ModelYear = 2023 });

            carManager.GetAll();





        }
    }
}