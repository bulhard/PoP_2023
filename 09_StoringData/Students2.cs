using CsvHelper;
using System.Globalization;

namespace _09_StoringData
{
    public static class Students2
    {
        public static Student[] students = new Student[] {
            new Student { Id=1, FirsName="Ivan", LastName="Last Ivan" },
            new Student { Id=2, FirsName="Maria", LastName= "Last Maria" },
            new Student { Id=3, FirsName="John", LastName = "Last John" },
            new Student { Id=4, FirsName="Jane", LastName = "Last Jane" },
        };

        public static void Write()
        {
            using (var writer = new StreamWriter("students2.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(students);
                }
            }
        }

        public static List<Student> Read()
        {
            using (var reader = new StreamReader("students2.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Student>();

                    return records.ToList();
                }
            }
        }
    }
}