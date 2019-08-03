﻿using PracticaFinal.Lib.Models.Relations;

namespace RentCars.Lib.Services.Dtos
{
    public class ReservaResponse
    {
        public ReservaResponseStatus Status { get; set; }

        public Reserva Reserva { get; set; }
    }

    public enum ReservaResponseStatus
    {
        Ok,
        MemberHasLimitOfCars,
        ThereAreNoAvailableCars,
    }
}
