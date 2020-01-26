namespace MagCourses.Models
{
    public class StudentSubjectGrade
    {


        public string SubjectName { get; set; }

        public int Grade { get; set; }

        public override string ToString() => $"{SubjectName} - {Grade}";
    }
}