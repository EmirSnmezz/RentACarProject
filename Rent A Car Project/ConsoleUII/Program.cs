using Business.Concrete;
using Core.Utilities.Results.Result.Concrete;
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

            // CarManager carManager = new CarManager(new efCarDal(_context));

            UserManager userManager = new UserManager(new efUserDal(_context));

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

            // var Result = carManager.CarDetail();


            //Console.WriteLine("******************************************* FİRMAYA AİT ARAÇ BİLGİLERİ ****************************************** ");
            //foreach (var car in Result.Data)
            //{
            //    Console.WriteLine
            //        ("--------------------------------" +
            //        "\nAraç Adı :{0}\n" +
            //        "Araç Rengi :{1}\n" +
            //        "Araç Markası :{2}\n" +
            //        "Araç Günlük Ücreti :{3}\n" +
            //        "--------------------------------",
            //        car.CarName,
            //        car.ColorName,
            //        car.BrandName,
            //        car.DailyPrice,
            //        Result.Message
            //        );
            //}

            //Console.WriteLine(Result.Message);
            CarManager carManager = new CarManager(new efCarDal(_context));

            Car myCar = carManager.GetAll(x => x.ID == 1).Data[0];

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal(_context));

            Customer myCustomer = customerManager.GetAll(x => x.UserId ==1).Data[0];

            RentalManager rentalManager = new RentalManager(new efRentalDal(_context));

           var Result = rentalManager.Rent(myCar, myCustomer);

            Console.WriteLine(Result.Message , Result);



        }

        private static void CustomerAdd(RentACarContext _context)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal(_context));

            //customerManager.Add(new Customer { UserId = 1, CompanyName = "Liberyus" });

            CarManager carManager = new CarManager(new efCarDal(_context));

            var myCar = carManager.GetAll(x => x.ID == 1);

            var myCustomer = customerManager.GetAll(x => x.UserId == 1);

            Console.WriteLine(myCustomer.Data[0].CompanyName);

            Console.WriteLine(myCustomer.Message);
        }

        private static void UserAddTest(UserManager userManager)
        {
            var result = userManager.Add
                            (new User
                            {
                                CompanyName = "Zİberyus",
                                Email = "emircan_snmez@outlook.com",
                                FirstName = " Onur ",
                                LastName = "Söner",
                                Id = 1,
                                Password = "Emir123."
                            }
                            );

            userManager.GetAll();

            Console.WriteLine(result.Message);
        }






    }
}