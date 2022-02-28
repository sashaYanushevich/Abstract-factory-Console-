using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    abstract class BottledDrinks
    {
        private string name;
        private double volume;

        public string Name
        {
            get=> name;
        }
        public double Volume
        {
            get => volume;
        }

        protected BottledDrinks()
        {
        }

        protected BottledDrinks(string name, double volume)
        {
            this.name = name;
            this.volume = volume;
        }

    }
}
