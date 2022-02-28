namespace napitki;
class Program
{
    static void Main(string[] args)
    {
        Napitok napitok = new Napitok(new LemonadeWithCognac());
        napitok.Structure();
    }
}