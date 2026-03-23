using OnetoManyEFMVC.Models;
using OnetoManyEFMVC.Repository;

namespace OnetoManyEFMVC.Services
{
    public class CollegeService
    {
        private readonly ICollegeRepository _repository;

        public CollegeService(ICollegeRepository repository)
        {
            _repository = repository;
        }

        public List<CollegeMaster> GetAllColleges()
        {
            return _repository.GetAllColleges();
        }

        public void AddCollege(CollegeMaster college)
        {
            _repository.AddCollege(college);
        }
    }
}