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
            _context.Update(course);
            _context.SaveChanges();
        }
        public async void Update2(Course course)
        {
            var existingCourse = await _context.Courses.FindAsync(course.Id);
            if (existingCourse == null)
            {
                throw new Exception("Course not found");
            }
            _context.Entry(existingCourse).State = EntityState.Detached;

            // Update the properties of the existing course with the new values

            _context.Attach(course);
            _context.Entry(course).State = EntityState.Modified;
       
            _context.SaveChanges();
        }
    }
}
