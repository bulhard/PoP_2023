namespace _06_OOP.Humans
{
    public class Worker : Human
    {
        private int Wage { get; set; }

        private int HoursWorked { get; set; }

        public Worker(int wage, int hoursWorked)
        {
            Wage = wage;
            HoursWorked = hoursWorked;
        }

        public int CalculateHourlyWage()
        {
            if (HoursWorked != 0)
            {
                return Wage / HoursWorked;
            }

            return 0;
        }
    }
}