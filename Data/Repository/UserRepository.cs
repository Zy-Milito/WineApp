using Data.Entities;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void AddUser(User newUser)
        {
            newUser.Id = _context.Users.Count() + 1;
            _context.Users.Add(newUser);
        }

        public User? Get(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
