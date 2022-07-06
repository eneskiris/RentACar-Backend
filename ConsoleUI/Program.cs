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
            CarTest();
            //BrandTest();
            //ColorTest();

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
            //car.CarId = 4;
            //carManager.Delete(car);



            //Console.WriteLine(carManager.GetById(1).CarName);




            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}




            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} / {1} / {2} / {3} / {4}", car.CarId, car.BrandName, car.CarName, car.ColorName, car.DailyPrice);

                    Console.WriteLine(result.Message);
                }

            }
            else
            {
                Console.WriteLine(result.Message); //Hata mesajı ayarlanacak.
            }

        }
    }
}

