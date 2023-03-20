using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _09_StoringData
{
    public static class StudentsJson
    {
        public static Student[] students = new Student[] {
            new Student { Id=1, FirsName="Ivan", LastName="Last Ivan" },
            new Student { Id=2, FirsName="Maria", LastName= "Last Maria" },
            new Student { Id=3, FirsName="John", LastName = "Last John" },
            new Student { Id=4, FirsName="Jane", LastName = "Last Jane" },
        };

        public static void Write()
        {
            string fileName = "students.json";

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };

            string jsonString = JsonSerializer.Serialize(students, options);

            File.WriteAllText(fileName, jsonString);
        }

        public static List<Student> Read()
        {
            var fileName = "students.json";

            var jsonString = File.ReadAllText(fileName);

            var data = JsonSerializer.Deserialize<List<Student>>(jsonString);

            return data;
        }
    }
}