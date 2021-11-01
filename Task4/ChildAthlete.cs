using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ChildAthlete:Athlete
    {
      private Boolean wasFirstPlace;

        public ChildAthlete(string LastName, int CountOfCompetitions, int SumOfPlaces,Boolean WasFirstPlace) : base(LastName, CountOfCompetitions, SumOfPlaces)
        {
            wasFirstPlace = WasFirstPlace;
            CalculateQ();
        }

        public bool WasFirstPlace { get => wasFirstPlace; set { wasFirstPlace = value; CalculateQ(); } }
        protected override void CalculateQ()
        {
            q = (double)countOfCompetitions / sumOfPlaces;
            if (wasFirstPlace) {q*=1.5; }
        }
        public override string ToString()
        {
            return "Last name: " + lastName + ", Count of competitions: " + countOfCompetitions + ", Sum of places: " + sumOfPlaces + ", Q: " + q+", Was first place: "+wasFirstPlace;
        }
    }
}
