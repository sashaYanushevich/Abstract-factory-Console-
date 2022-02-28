using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    abstract class AlcoholicDrinks : BottledDrinks
    {
        private double degreeAlcohol { get; set; }

        protected AlcoholicDrinks(string name,double volume,double degreeAlcohol) : base (name,volume)
        {
            this.degreeAlcohol = degreeAlcohol;
        }
        public abstract void TypeAlcoholicDrink();
    }
}
