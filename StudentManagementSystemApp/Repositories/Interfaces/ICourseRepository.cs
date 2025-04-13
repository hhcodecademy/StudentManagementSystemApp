using StudentManagementSystemApp.Entities;

namespace StudentManagementSystemApp.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllAsync();
        Task<Course> GetByIdAsync(int id);

        void Update(Course course);

        Task<Course> CreateAsync(Course course);

    }
}
