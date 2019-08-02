using System;

namespace RentCars.Lib.Services.Dtos
{
    public class ReservaRequest
    {
        public Guid CarId { get; set; }
        public Guid MemberId { get; set; }
    }
}
