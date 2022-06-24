using System;

namespace OP4
{
    public class Dentist : Doctor, IStomatology
    {
        public Dentist(int salary) : base(salary)
        {
        }

        public int FixTooth(int countOfFix)
        {
            return YearOfWork * Salary * countOfFix;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"I am a dentist, with a {YearOfWork} years of work, my salary is: {Salary}");
        }
    }
}