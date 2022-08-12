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
    public class EfRentalDal : EfEntityRepositoryBase<Rental,AutoShowroomContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (AutoShowroomContext context = new AutoShowroomContext())
            {
                var result = from c in context.Cars
                             join re in context.Rentals
                             on c.CarId equals re.CarId
                             join cu in context.Customers
                             on re.CustomerId equals cu.CustomerId
                             join names in context.Users on cu.UserId
                             equals names.UserId
                             join br in context.Brands
                             on c.BrandId equals br.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new RentalDetailDto
                             {
                                 CustomerName = names.FirstName +" "+names.LastName,
                                 BrandName = br.BrandName,
                                 ModelName = c.CarName,
                                 ColorName = co.ColorName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}

