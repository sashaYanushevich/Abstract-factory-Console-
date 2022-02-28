using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    abstract class BottleFactory
    {
        public abstract AlcoholicDrinks alcDrink();
        public abstract Drinks drink();
    }
}
