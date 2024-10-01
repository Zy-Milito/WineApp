using Data.Entities;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public List<User> Users { get; set; }
        public UserRepository()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Username = "Lukas",
                    Password = "password"
                },
                new User()
                {
                    Id = 2,
                    Username = "Samantha",
                    Password = "password"
                },
                new User()
                {
                    Id = 3,
                    Username = "Friedrich",
                    Password = "password"
                }
            };
        }

        public List<User> GetAll()
        {
            return Users;
        }

        public void AddUser(User newUser)
        {
            newUser.Id = Users.Count() + 1;
            Users.Add(newUser);
        }
    }
}
