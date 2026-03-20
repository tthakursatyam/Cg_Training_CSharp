using UserDetails.Data;
using UserDetails.Models;
namespace UserDetails.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDetailsDbContext _context;

        public UserRepository()
        {
            _context = new UserDetailsDbContext();
        }

        public bool AddUser(UserDetail userDetails)
        {
            _context.userDetails.Add(userDetails);

            return _context.SaveChanges()>0;
        }

        public bool EditUser(UserDetail userDetails)
        {
            _context.userDetails.Update(userDetails);

            return _context.SaveChanges() > 0;
        }
        public UserDetail GetUser(int id)
        {
            return _context.userDetails.FirstOrDefault(x => x.Id == id);

        }
        public List<UserDetail> GetUserList()
        {
            return _context.userDetails.ToList();
        }
    }
}
