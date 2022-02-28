using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    internal class Vino : AlcoholicDrinks
    {
        private string typeVino { get; set; }
        public Vino(string name, double volume, double degreeAlcohol, string typeVino) : base(name, volume, degreeAlcohol)
        {
            this.typeVino = typeVino;
        }

        public override void TypeAlcoholicDrink()
        {
            Console.WriteLine($"Это {typeVino} вино.");
        }
    }
}
