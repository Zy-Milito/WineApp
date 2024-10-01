using Common.DTO;
using Data.Entities;

namespace Services
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        void AddUser(UserForCreation userForCreation);
    }
}
