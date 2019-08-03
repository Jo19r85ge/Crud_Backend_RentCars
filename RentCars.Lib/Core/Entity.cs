using System;

namespace RentCars.Lib.Core
{
    public class Entity
    {
        public Guid Id { get; set; }

        public string EntityType
        {
            get
            {
                return GetType().Name;
            }
        }
    }
}
