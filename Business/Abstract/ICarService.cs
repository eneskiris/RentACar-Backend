using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);

        Car GetById(int carId);

        List<Car> GetCarsByBrandId(int brandId);

        List<Car> GetCarsByColorId(int colorId);

        List<CarDetailDto> GetCarDetails();


    }
}

