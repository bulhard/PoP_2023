namespace _05_TextFiles
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentNumber { get; set; }

        public override string ToString()
        {
            return $"{FirstName};{LastName};{StudentNumber}";
        }
    }
}