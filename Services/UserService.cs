using Common.DTO;
using Data.Entities;
using Data.Repository;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public void AddUser(UserForCreation userForCreation)
        {
            User newUser = new User()
            {
                Username = userForCreation.Username,
                Password = userForCreation.Password
            };
            _userRepository.AddUser(newUser);
        }

        public User? AuthenticateUser(string username, string password)
        {
            User? userToReturn = _userRepository.Get(username);
            if (userToReturn is not null && userToReturn.Password == password)
                return userToReturn;
            return null;
        }
    }
}
