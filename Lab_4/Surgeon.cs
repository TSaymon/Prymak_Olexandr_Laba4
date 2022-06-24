using System;

namespace OP4
{
    public class Surgeon : Doctor
    {
        public Surgeon(int salary) : base(salary)
        {
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"I am a surgeon, with a {YearOfWork} years of work, my salary is: {Salary}");
        }
    }
}