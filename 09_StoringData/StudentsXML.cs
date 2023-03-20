using System.Xml.Serialization;

namespace _09_StoringData
{
    public static class StudentsXML
    {
        public static Student[] students = new Student[] {
            new Student { Id=1, FirsName="Ivan", LastName="Last Ivan" },
            new Student { Id=2, FirsName="Maria", LastName= "Last Maria" },
            new Student { Id=3, FirsName="John", LastName = "Last John" },
            new Student { Id=4, FirsName="Jane", LastName = "Last Jane" },
        };

        public static void Write()
        {
            XmlSerializer x = new XmlSerializer(typeof(Student[]));

            using (TextWriter writer = new StreamWriter("studentsXML.txt"))
            {
                x.Serialize(writer, students);
            }
        }

        public static List<Student> Read()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Student[]));

            using (FileStream fs = new FileStream("studentsXML.txt", FileMode.Open))
            {
                var students = (Student[])serializer.Deserialize(fs);
            }

            return students.ToList();
        }
    }
}