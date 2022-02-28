using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    internal class Beer : AlcoholicDrinks
    {
        private string typeBeer { get; set; }

        public Beer(string name, double volume, double degreeAlcohol, string typeBeer) : base (name,volume,degreeAlcohol)
        {
            this.typeBeer = typeBeer;
        }


        public override void TypeAlcoholicDrink()
        {
            Console.WriteLine("Это пиво");
        }
    }
}
