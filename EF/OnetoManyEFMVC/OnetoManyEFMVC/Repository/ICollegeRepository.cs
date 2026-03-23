using OnetoManyEFMVC.Models;

namespace OnetoManyEFMVC.Repository
{
    public interface ICollegeRepository
    {
        List<CollegeMaster> GetAllColleges();

        void AddCollege(CollegeMaster college);
    }
}