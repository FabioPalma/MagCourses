namespace MagCourses.Models
{
    public class StudentGrade
    {

        public string StudentName { get; set; }

        public int Grade { get; set; }
      
        public override string ToString() => $"{StudentName} - {Grade}";
    }
}