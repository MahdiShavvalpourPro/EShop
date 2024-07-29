using EShop.Models.Entities;

namespace EShop.Data.Repositories
{
    public interface IUserRepository
    {
        public void AddUser(User user);
        public bool UserExists(string phone);
        public User Get(string phone,string password);
    }

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User Get(string phone,string password)
        {
            return _context.Users.FirstOrDefault(x => x.PhoneNumber == phone && x.Password.Contains(password))!;
        }

        public bool UserExists(string phone)
        {
            return _context.Users.Any(u => u.PhoneNumber == phone);
        }
    }
}
