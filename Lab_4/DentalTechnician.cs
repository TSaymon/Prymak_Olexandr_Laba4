using System;

namespace OP4
{
    public class DentalTechnician : Dentist
    {
        public DentalTechnician(int salary) : base(salary)
        {
            YearOfWork = 15;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"I am a dentist technician, with a {YearOfWork} years of work, my salary is: {Salary}");
        }
    }
}