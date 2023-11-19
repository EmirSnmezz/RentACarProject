using Business.Concrete;
using Data_Access.Abstarct;
using Data_Access.Concrete.Entity_Framework;
using Data_Access.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;

namespace ConsoleUII
{
    public class Program
    {
        public static void Main(string[] args)
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

            //carManager.Add(new Car {ID = 3 , BrandId = 2, ColorId = 3, DailyPrice = 3000, Description = "BMW 5.30 i 245 HP RWD ", ModelYear = 2023 });

            //foreach( var car in carManager.GetAll())
            //{
            //    Console.WriteLine
            //        (
            //        "****************************Araç Bilgileri***********************\n" +
            //        "Araç ID : {0}\n"+
            //        "Renk ID: {1}\n"+
            //        "Marka ID: {2}\n"+
            //        "Model Yılı {3}\n"+
            //        "Günlük Kira : {4}\n"+
            //        "Araç Bilgileri {5}" , 
            //        car.ID,
            //        car.ColorId,
            //        car.BrandId,
            //        car.ModelYear,
            //        car.DailyPrice,
            //        car.Description
            //        );
            //}

            var Result = carManager.CarDetail();


            Console.WriteLine("******************************************* FİRMAYA AİT ARAÇ BİLGİLERİ ****************************************** ");
            foreach (var car in Result.Data)
            {
                Console.WriteLine
                    ("--------------------------------" +
                    "\nAraç Adı :{0}\n" +
                    "Araç Rengi :{1}\n" +
                    "Araç Markası :{2}\n" +
                    "Araç Günlük Ücreti :{3}\n" +
                    "--------------------------------",
                    car.CarName,
                    car.ColorName,
                    car.BrandName,
                    car.DailyPrice,
                    Result.Message
                    );
            }
            
            Console.WriteLine(Result.Message);
        }


        
            
           

        
    }
}