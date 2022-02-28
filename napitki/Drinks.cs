using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    abstract class Drinks : BottledDrinks
    {
        protected Drinks(string name, double volume) : base(name, volume)
        {
            
        }
        public abstract void TypeDrink();
    }
}
