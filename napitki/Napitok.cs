using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    internal class Napitok
    {
        private AlcoholicDrinks alDrinks { get; set; }
        private Drinks drinks { get; set; }

        public Napitok(BottleFactory factory)
        {
            alDrinks = factory.alcDrink();
            drinks = factory.drink();
        }
        public void Structure()
        {
            alDrinks.TypeAlcoholicDrink();
            drinks.TypeDrink();
        }
    }
}
