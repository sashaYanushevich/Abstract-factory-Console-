using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    internal class LemonadeWithCognac : BottleFactory
    {
        public override AlcoholicDrinks alcDrink() 
        {
            return new Cognac();
        }
        public override Drinks drink()
        {
            return new Lemonade();
        }
    }
}
