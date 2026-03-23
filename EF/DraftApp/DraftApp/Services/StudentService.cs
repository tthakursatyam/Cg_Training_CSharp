using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DraftApp.Models;
using DraftApp.Repositories;

namespace DraftApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> SearchAsync(string q = null)
        {
            var students = await _repo.GetAllAsync();

            if (string.IsNullOrWhiteSpace(q))
                return students.ToList();

            q = q.ToLower();

            return students
                .Where(s =>
                    (!string.IsNullOrEmpty(s.FullName) && s.FullName.ToLower().Contains(q)) ||
                    (!string.IsNullOrEmpty(s.Email) && s.Email.ToLower().Contains(q)) ||
                    (!string.IsNullOrEmpty(s.Phone) && s.Phone.Contains(q))
                )
                .ToList();
        }

        public async Task<Student> GetAsync(int id)
        {
            var student = await _repo.GetByIdAsync(id);

            if (student == null)
                throw new Exception("Student not found");

            return student;
        }

        public async Task CreateAsync(Student student)
        {
            student.CreatedAt = DateTime.Now;

            await _repo.AddAsync(student);
        }

        public async Task UpdateAsync(Student student)
        {
            await _repo.UpdateAsync(student);
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}