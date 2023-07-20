namespace GPA_Calculator_Library.Models
{
    public class CourseModel
    {
        public int Id { get; set; }

        public string CourseName { get; set; } = string.Empty;

        public int CreditHours { get; set; }

        public string Grade { get; set; } = string.Empty;
    }
}
