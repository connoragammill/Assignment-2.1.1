namespace Assignment_2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentId = 202003;
            student.FirstName = "Connor";
            student.LastName = "Gammill";
            student.StudentGrade = "C+";
            
            Console.WriteLine("Student ID:" + student.StudentId);
            Console.WriteLine("First Name:" + student.FirstName);
            Console.WriteLine("Last Name:" + student.LastName);
            Console.WriteLine("Student Grade:" + student.StudentGrade);
        }
    }

    public class Student
    {
        private int studentId;
        private string firstName;
        private string lastName;
        private string studentGrade;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }
    }

    
}
