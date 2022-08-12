using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { CarId=1, BrandId=1, ColorId=1, DailyPrice=500, Description="Car 1", ModelYear=2022},
                new Car { CarId=2, BrandId=1, ColorId=1, DailyPrice=400, Description="Car 2", ModelYear=2021},
                new Car { CarId=3, BrandId=2, ColorId=2, DailyPrice=150, Description="Car 3", ModelYear=2010},
                new Car { CarId=4, BrandId=2, ColorId=2, DailyPrice=100, Description="Car 4", ModelYear=2008}
            };

            _brands = new List<Brand>
            {
                new Brand{ BrandId=1, BrandName="Mercedes"},
                new Brand{ BrandId=2, BrandName="Fiat"}
            };

            _colors = new List<Color>
            {
                new Color{ ColorId =1, ColorName="Black"},
                new Color{ ColorId =2, ColorName="White"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(deleteCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(x => x.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateCar = _cars.SingleOrDefault(x => x.CarId == car.CarId);

            updateCar.CarId = car.CarId;
            updateCar.BrandId = car.BrandId;
            updateCar.ColorId = car.ColorId;
            updateCar.ModelYear = car.ModelYear;
            updateCar.DailyPrice = car.DailyPrice;
            updateCar.Description = car.Description;

        }
    }
}

