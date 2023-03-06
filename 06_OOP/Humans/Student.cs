namespace _06_OOP.Humans
{
    public class Student : Human
    {
        public Student()
        {
            Address = new Address();
        }

        public int Mark { get; set; }

        public Address Address { get; set; }
    }
}