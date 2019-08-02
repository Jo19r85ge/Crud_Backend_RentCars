using RentCars.Lib.Services.Dtos;

namespace RentCars.Lib.Services.Interfaces
{
    public interface IRegisterService
    {
        RegisterResponse Register(RegisterRequest registerRequest);
    }
}
