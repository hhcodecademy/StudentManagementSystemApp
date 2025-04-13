using Microsoft.AspNetCore.Mvc;
using StudentManagementSystemApp.Services;
using StudentManagementSystemApp.Services.Interfaces;

namespace StudentManagementSystemApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

      
        public async Task<IActionResult> Index()
        {
            var items =  await _courseService.GetAllAsync();

            return View(items);
        }
    }
}
