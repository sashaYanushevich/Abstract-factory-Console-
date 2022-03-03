namespace napitki;
class Program
{
    static void Main(string[] args)
    {
        Napitok napitok = new Napitok(new LemonadeWithCognac());
        napitok.alDrinks = new Cognac("Кахети",0.5,40,"Дубовый");
        napitok.drinks = new Lemonade("Тархун", "Тархун", 1);
        Console.WriteLine("Смешиваем:");
        napitok.Structure();

    }
}