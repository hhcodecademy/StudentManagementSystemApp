using AutoMapper;
using StudentManagementSystemApp.Dtos;
using StudentManagementSystemApp.Entities;

namespace StudentManagementSystemApp.Profiles
{
    public class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<Course,CourseDto>().ReverseMap();
        }
    }
}
