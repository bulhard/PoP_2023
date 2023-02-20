namespace _05_TextFiles
{
    public static class StudentService
    {
        public static string fileName = "students.txt";

        public static Student ReadStudentFromConsole()
        {
            var student = new Student();

            Console.Write("First name: ");
            student.FirstName = Console.ReadLine();

            Console.Write("Last name: ");
            student.LastName = Console.ReadLine();

            Console.Write("Student number: ");
            student.StudentNumber = Console.ReadLine();

            return student;
        }

        public static void WriteStudent(Student student)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(student);
            }
        }

        public static void ReadAllStudents()
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    Student student = line.ToStudent();

                    Console.WriteLine($"{student.FirstName} {student.LastName}");

                    line = reader.ReadLine();
                }
            }
        }

        public static Student ToStudent(this string student)
        {
            var studentArray = student.Split(";");

            return new Student
            {
                FirstName = studentArray[0],
                LastName = studentArray[1],
                StudentNumber = studentArray[2]
            };
        }
    }
}