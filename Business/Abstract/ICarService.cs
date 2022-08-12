using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

        IDataResult<List<Car>> GetAll();

        IDataResult<Car> GetById(int carId);

        IDataResult<List<Car>> GetCarsByBrandId(int brandId);

        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IDataResult<List<CarDetailDto>> GetCarDetailByBrandId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetailByColorId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetailById(int id);

        IDataResult<List<CarDetailDto>> GetCarDetailByColorAndByBrand(int colorId, int brandId);

        IDataResult<List<CarDetailDto>> GetCarDetails();


    }
}

