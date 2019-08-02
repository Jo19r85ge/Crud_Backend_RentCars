using RentCars.Lib.Core;
using RentCars.Lib.Services.Dtos;

namespace RentCars.Lib.Services.Interfaces
{
    public interface ILoginService
    {
        User Authenticate(LoginRequest loginRequest);
    }
}
