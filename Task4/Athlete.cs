using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Athlete
    {
        protected String lastName;
        protected int countOfCompetitions;
        protected int sumOfPlaces;
        protected double q;

        public Athlete(string LastName, int CountOfCompetitions, int SumOfPlaces)
        {
            lastName = LastName;
            countOfCompetitions = CountOfCompetitions;
            sumOfPlaces = SumOfPlaces;
            q = (double)countOfCompetitions / sumOfPlaces;
        }

        public string LastName { get => lastName; }
        public int CountOfCompetitions { get => countOfCompetitions; set { countOfCompetitions = value; CalculateQ(); } }
        public int SumOfPlaces { get => sumOfPlaces; set { sumOfPlaces = value;CalculateQ(); } }
        public double Q { get =>q;  }
        protected virtual void CalculateQ()
        {
            q = (double)countOfCompetitions / sumOfPlaces;
        }
        public override string ToString()
        {
            return "Last name: "+lastName+ ", Count of competitions: "+countOfCompetitions+", Sum of places: "+sumOfPlaces+", Q: "+q;
        }
    }
    

}
