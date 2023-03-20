using System.Text.Json.Serialization;

namespace _09_StoringData
{
    public class Student
    {
        public int Id { get; set; }

        [JsonPropertyName("Fist name")]
        public string FirsName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }
    }
}