using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    internal class MineralWater : Drinks
    {
        private string typeWater { get; set; }
        public MineralWater(string typeWater, string name, double volume) : base(name, volume)
        {
            this.typeWater = typeWater;
        }

        public override void TypeDrink()
        {
            Console.WriteLine("Это миниралка " + typeWater);
        }
    }
}
