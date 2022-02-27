using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    abstract class BottledDrinks
    {
        private string name { get; set; }
        private double volume { get; set; }

        protected BottledDrinks(string name, double volume)
        {
            this.name = name;
            this.volume = volume;
        }

    }
}
