using UserDetails.Models;
namespace UserDetails.Repository
{
    public interface IUserRepository
    {
        public bool AddUser(UserDetail userDetails);
        public bool EditUser(UserDetail userDetails);
        public UserDetail GetUser(int id);
        public List<UserDetail> GetUserList();

    }
}
