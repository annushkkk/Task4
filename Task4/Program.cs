using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete = new Athlete("Kim", 10, 3);
            Console.WriteLine(athlete);
            athlete.CountOfCompetitions=12;
            Console.WriteLine(athlete);
            athlete.SumOfPlaces = 5;
            Console.WriteLine(athlete);

            ChildAthlete childAthlete = new ChildAthlete("Jakson",10,3,true);
            Console.WriteLine(childAthlete);
            childAthlete.CountOfCompetitions = 12;
            Console.WriteLine(childAthlete);
            childAthlete.WasFirstPlace = false;
            Console.WriteLine(childAthlete);
            childAthlete.SumOfPlaces = 5;
            Console.WriteLine(childAthlete);

        }
    }
}
