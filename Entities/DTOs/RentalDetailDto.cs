using System;
using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public string ColorName { get; set; }

        public string CustomerName { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}

