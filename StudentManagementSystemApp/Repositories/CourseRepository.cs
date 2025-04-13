using Microsoft.EntityFrameworkCore;
using StudentManagementSystemApp.Data;
using StudentManagementSystemApp.Entities;
using StudentManagementSystemApp.Repositories.Interfaces;

namespace StudentManagementSystemApp.Repositories
{
    public class CourseRepository : ICourseRepository
    {

        private readonly AppDbContext _context;
        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Course> CreateAsync(Course course)
        {
            await _context.AddAsync(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<List<Course>> GetAllAsync()
        {
           var items = await _context.Courses.ToListAsync();
            return items;
        }

        public async Task<Course> GetByIdAsync(int id)
        {
           var data = await _context.Courses.FindAsync(id);
            return data;
        }

        public async void Update(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }
    }
}
