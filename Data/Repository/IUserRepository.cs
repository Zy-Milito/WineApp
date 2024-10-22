using Data.Entities;

namespace Data.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
        void AddUser(User newUser);
        User? Get(string username);
    }
}
