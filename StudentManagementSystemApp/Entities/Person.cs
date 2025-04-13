namespace StudentManagementSystemApp.Entities
{
    public abstract class Person :BaseEntity
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
