using StudentManagementSystemApp.Dtos;
using StudentManagementSystemApp.Entities;

namespace StudentManagementSystemApp.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<CourseDto>> GetAllAsync();
        Task<CourseDto> GetByIdAsync(int id);

        Task UpdateAsync(CourseDto course);

        Task<CourseDto> CreateAsync(CourseDto course);

        Task DeleteAsync(int id);
    }
}
