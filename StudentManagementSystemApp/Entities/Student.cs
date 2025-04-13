using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystemApp.Entities
{
    public class Student :Person
    {
        public string StudentCode { get; set; }
        public ICollection<Point> Points { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
