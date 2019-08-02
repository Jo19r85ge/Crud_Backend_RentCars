using Newtonsoft.Json;
using PracticaFinal.Lib.Models.Relations;
using RentCars.Lib.Core;
using System;
using System.Collections.Generic;

namespace RentCars.Lib.Models
{
    public class Car : Entity
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Door { get; set; }
        public DateTime? PublicationDate { get; set; }

        [JsonIgnore]
        public ICollection<Reserva>Reservas { get; set; }
    }
}
