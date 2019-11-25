namespace salary
{
    public class EmployeesSalary
    {
        private int id;
        private string name;
        private string position;
        private string gender;

        public EmployeesSalary(int id, string name, string position, string gender)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.gender = gender;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public double MonthlySalary(double grossSalary)
        {
            double salary;
            salary = grossSalary - (((grossSalary * 30) / 100) + ((grossSalary * 5) / 100) + ((grossSalary * 3) / 100));
            return salary;
        }

        public double HourlySalary(double rate, double hour)
        {
            double salary;
            salary=(rate*hour)-((((rate*hour)*5)/100)+(((rate*hour)*3)/100));
            return salary;
        }

        public double OneTimeSalary(double grossSalary)
        {
            double salary;
            salary = grossSalary - ((grossSalary * 30) / 100);
            return salary;
        }
    }
}