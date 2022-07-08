using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            //UserTest();
            //CustomerTest();
            //RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //Rental rental = new Rental() { CarId = 1, CustomerId = 1, RentDate = new DateTime(2022,07,08), ReturnDate = new DateTime(2022,09,09)};
            //rentalManager.Add(rental);

            //Rental rental = new Rental() { Id=14, CarId=2, CustomerId=1, RentDate = new DateTime(2022,08,09), ReturnDate = new DateTime(2022,10,13)};
            //rentalManager.Update(rental);

            //Rental rental = new Rental() { Id=13, CarId=1, CustomerId=1, RentDate = new DateTime(2022,08,09), ReturnDate = new DateTime(2022,10,13)};
            //rentalManager.Delete(rental);

            //var result = rentalManager.GetAll();

            //foreach (var rental in result.Data)
            //{
            //    Console.WriteLine("CustomerId : {0} / CarId : {1} / RentDate : {2} / ReturnDate : {3}",rental.CustomerId,rental.CarId,rental.RentDate,rental.ReturnDate);
            //}
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //Customer customer = new Customer() { UserId = 3, CompanyName = "APPLE" };
            //customerManager.Add(customer);

            //Customer customer = new Customer() { CustomerId=1, UserId=3, CompanyName="ENES"};
            //customerManager.Update(customer);

            //Customer customer = new Customer();
            //customer.CustomerId = 2;
            //customerManager.Delete(customer);

            //var result = customerManager.GetAll();

            //foreach (var customer in result.Data)
            //{
            //    Console.WriteLine(customer.CompanyName);
            //}
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            //User user = new User() { FirstName = "Kırış", LastName = "Enes", Email = "kirisenes", Password = "psswd" };
            //userManager.Add(user);

            //User user = new User() { UserId=2,FirstName="Test", LastName="tesT", Email="testmail", Password="test"};
            //userManager.Update(user);

            //User user = new User();
            //user.UserId = 2;
            //userManager.Delete(user);

            //var result = userManager.GetAll();

            //foreach (var user in result.Data)
            //{
            //    Console.WriteLine("{0} / {1} / {2}",user.FirstName,user.LastName,user.Email);
            //}
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //Color color = new Color() { ColorName="Blue"};
            //colorManager.Add(color);

            //Color color = new Color() { ColorId=3, ColorName="Orange"};
            //colorManager.Update(color);

            //Color color = new Color() { ColorId=3 };
            //colorManager.Delete(color);

            
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}


            //Console.WriteLine(colorManager.GetById(1).ColorName);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Brand brand = new Brand() { BrandName="BMW"};
            //brandManager.Add(brand);

            //Brand brand = new Brand() { BrandId=3, BrandName="Porsche"};
            //brandManager.Update(brand);

            //Brand brand = new Brand();
            //brand.BrandId=3;
            //brandManager.Delete(brand);

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            //Console.WriteLine(brandManager.GetById(1).BrandName);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //Car car = new Car() { BrandId = 2, ColorId = 1, CarName = "TEST", ModelYear = 1990, DailyPrice = 999, Description = "TEST" };
            //carManager.Add(car);



            //Car car = new Car() { CarId=5, BrandId=1, ColorId=2, CarName="test", ModelYear=1999, DailyPrice=1000, Description="test"};
            //carManager.Update(car);



            //Car car = new Car();
            //car.CarId = 6;
            //carManager.Delete(car);


            //var result = carManager.GetById(1);
            //Console.WriteLine(result.Data.CarName);




            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}




            //var result = carManager.GetCarDetails();

            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine("{0} / {1} / {2} / {3} / {4}", car.CarId, car.BrandName, car.CarName, car.ColorName, car.DailyPrice);

            //        Console.WriteLine(result.Message);
            //    }

            //}
            //else
            //{
            //    Console.WriteLine(result.Message); //Hata mesajı ayarlanacak.
            //}

        }
    }
}

