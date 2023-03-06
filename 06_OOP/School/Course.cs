namespace _06_OOP.School
{
    public class Course
    {
        public string Name { get; set; }

        private List<Class> Classes { get; set; }

        public int TeacherID { get; set; }

        public int ClassesCount
        {
            get
            {
                return Classes.Count;
            }
        }
    }
}