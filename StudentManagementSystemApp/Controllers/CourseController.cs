using Microsoft.AspNetCore.Mvc;
using StudentManagementSystemApp.Dtos;
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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = await _courseService.GetAllAsync();

            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseDto dto)
        {

            try
            {
                throw new Exception();

                var savedDto = await _courseService.CreateAsync(dto);
                if (savedDto is not null && savedDto.Id > 0)
                {
                    ViewData["SuccessMessage"] = $"{savedDto.Id} successfully added";
                }

            }
            catch (Exception ex)
            {

                ViewData["ErrorMessage"] = $"Record dont successfully added.Error :{ex.Message}";
            }

            return View();
            //return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var item = await _courseService.GetByIdAsync(id);
            return View(item);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CourseDto dto)
        {

            await _courseService.UpdateAsync(dto);

            ViewData["SuccessMessage"] = $"{dto.Id} successfully updated";

            // return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _courseService.GetByIdAsync(id);
            return View(item);
        }
        [HttpPost]
        public async Task<IActionResult> PostDelete(int id)
        {
            await _courseService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
