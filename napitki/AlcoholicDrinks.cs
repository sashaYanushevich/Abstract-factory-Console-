using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    abstract class AlcoholicDrinks : BottledDrinks
    {
        protected double degreeAlcohol;

        public double DegreeAlcohol
        {
            get => degreeAlcohol;
        }
        protected AlcoholicDrinks()
        {
        }

        protected AlcoholicDrinks(string name,double volume,double degreeAlcohol) : base (name,volume)
        {
            this.degreeAlcohol = degreeAlcohol;
        }
        public abstract void TypeAlcoholicDrink();
    }
}
