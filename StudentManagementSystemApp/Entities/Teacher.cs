namespace StudentManagementSystemApp.Entities
{
    public class Teacher :Person
    {
       public decimal Salary { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
