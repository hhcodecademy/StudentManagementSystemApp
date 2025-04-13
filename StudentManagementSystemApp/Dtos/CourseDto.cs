namespace StudentManagementSystemApp.Dtos
{
    public record CourseDto : BaseDto
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
