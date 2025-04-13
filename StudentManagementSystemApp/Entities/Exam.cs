namespace StudentManagementSystemApp.Entities
{
    public class Exam:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ExamDate { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
