using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,AutoShowroomContext> ,ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (AutoShowroomContext context = new AutoShowroomContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                CarId = c.CarId,
                                BrandId = b.BrandId,
                                ColorId = co.ColorId,
                                CarName = c.CarName,
                                BrandName = b.BrandName,
                                ColorName = co.ColorName,
                                ModelYear = c.ModelYear,
                                Description = c.Description,
                                DailyPrice = c.DailyPrice,
                                ImagePath = (from m in context.CarImages where m.CarId == c.CarId select m.ImagePath).FirstOrDefault()
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

    }
}

