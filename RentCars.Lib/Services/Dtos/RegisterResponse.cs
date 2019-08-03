using RentCars.Lib.Models;

namespace RentCars.Lib.Services.Dtos
{
    public class RegisterResponse
    {
        public RegisterResponseStatus Status { get; set; }
        public Member Member { get; set; }
    }

    public enum RegisterResponseStatus
    {
        Ok,
        UserWithEmailAlreadyExists,
        WrongEmail,
        MissingEmail,
        MissingPassword,
        PasswordInsecure
    }
}
