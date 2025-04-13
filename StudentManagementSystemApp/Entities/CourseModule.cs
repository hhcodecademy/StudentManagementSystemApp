namespace StudentManagementSystemApp.Entities
{
    public class CourseModule : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<Unit> Units { get; set; }
    }
}
