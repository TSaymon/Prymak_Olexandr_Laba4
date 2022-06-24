namespace OP4
{
    public abstract class Doctor
    {
        protected int Salary;
        protected int YearOfWork;

        public Doctor(int salary)
        {
            Salary = salary;
            YearOfWork = 10;
        }

        public abstract void ShowInformation();
    }
}