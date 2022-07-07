using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        public IResult Add(Rental rental);
        public IResult Delete(Rental rental);
        public IResult Update(Rental rental);
    }
}

