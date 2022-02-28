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
            return new Cognac("Старый Кахети",0.5,40,"Дубовый");
        }
        public override Drinks drink()
        {
            return new Lemonade("Тархун","Тархун",1);
        }
    }
}
