using Newtonsoft.Json;
using PracticaFinal.Lib.Models.Relations;
using RentCars.Lib.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentCars.Lib.Models
{
    public class Member : User
    {
        [JsonIgnore]
        public ICollection<Reserva> Reservas { get; set; }

        public List<Guid> ReservasIds
        {
            get
            {
                return Reservas == null ? new List<Guid>() : Reservas.Select(x => x.Id).ToList();
            }
        }
    }
}
