using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    internal class Milk : Drinks
    {
        private double fattiness { get; set; }

        public Milk(double fattiness,string name,double volume) : base(name,volume)
        {
            this.fattiness = fattiness;
        }
    }
}
