using System;

namespace OP4
{
    public class Neurosurgeon : Surgeon
    {
        public Neurosurgeon(int salary) : base(salary)
        {
            YearOfWork = 20;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"I am a neurosurgeon, with a {YearOfWork} years of work, my salary is: {Salary}");
        }
    }
}