using AutoMapper;
using StudentManagementSystemApp.Dtos;
using StudentManagementSystemApp.Entities;
using StudentManagementSystemApp.Repositories.Interfaces;
using StudentManagementSystemApp.Services.Interfaces;

namespace StudentManagementSystemApp.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<CourseDto> CreateAsync(CourseDto courseDto)
        {

            var inputEntity = _mapper.Map<Course>(courseDto);
            var outputEntity = await _courseRepository.CreateAsync(inputEntity);
            var dto = _mapper.Map<CourseDto>(outputEntity);
            return dto;
        }

        public async Task<List<CourseDto>> GetAllAsync()
        {
            var items = await _courseRepository.GetAllAsync();
            var dtos = _mapper.Map<List<CourseDto>>(items);
            return dtos;
        }

        public async Task<CourseDto> GetByIdAsync(int id)
        {
            var item = await _courseRepository.GetByIdAsync(id);
            var dto = _mapper.Map<CourseDto>(item);
            return dto;
        }

        public async Task UpdateAsync(CourseDto courseDto, int id)
        {
            var item = _courseRepository.GetByIdAsync(id);
            if (item is not null)
            {
                var entity = _mapper.Map<Course>(courseDto);
                _courseRepository.Update(entity);
            }
        }
    }
}
