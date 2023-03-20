namespace _09_StoringData
{
    public static class Students
    {
        public static Student[] students = new Student[] {
            new Student { Id=1, FirsName="Ivan", LastName="Last Ivan" },
            new Student { Id=2, FirsName="Maria", LastName= "Last Maria" },
            new Student { Id=3, FirsName="John", LastName = "Last John" },
            new Student { Id=4, FirsName="Jane", LastName = "Last Jane" },
        };

        public static void Write()
        {
            // Create a StreamWriter instance
            StreamWriter writer = new StreamWriter("student.txt");

            // Ensure the writer will be closed when no longer used
            using (writer)
            {
                foreach (Student student in students)
                {
                    writer.WriteLine(student.Id.ToString() + ";" + student.FirsName);
                }
            }
        }

        public static List<Student> Read()
        {
            List<Student> result = new List<Student>();

            // Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("student.txt");
            using (reader)
            {
                // Read first line from the text file
                string line = reader.ReadLine();

                // Read the other lines from the text file
                while (line != null)
                {
                    var lineArray = line.Split(";");

                    result.Add(new Student
                    {
                        Id = int.Parse(lineArray[0]),
                        FirsName = lineArray[1]
                    });

                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}