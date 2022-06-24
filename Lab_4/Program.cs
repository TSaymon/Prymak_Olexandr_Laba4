using System;
using System.Collections.Generic;
using System.Linq;

namespace OP4
{
    class Program
    {
        static void Main(string[] args)
        {
            var hospital = new List<Doctor>();

            var dentist = new Dentist(100);
            var dentalTechnician = new DentalTechnician(200);
            var surgeon = new Surgeon(250);
            var neurosurgeon = new Neurosurgeon(500);

            hospital.Add(dentist);
            hospital.Add(dentalTechnician);
            hospital.Add(surgeon);
            hospital.Add(neurosurgeon);

            hospital.ForEach(doctor => doctor.ShowInformation());
            var stomatologies = hospital.Where(doctor => doctor is IStomatology).ToList();

            Console.WriteLine("Salary: ");

            foreach (Dentist dentist1 in stomatologies)
            {
                dentist.ShowInformation();
                Console.WriteLine("Count of work 10 tooth: " + dentist1.FixTooth(10));

            }

        }
    }
}