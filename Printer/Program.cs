namespace Lab_5;

class Program
{
    private static ColourfulPrinter hpPrinter = new ColourfulPrinter();
    static void Main(string[] args)
    {
        hpPrinter.Print("Welcome to HP.");
        hpPrinter.Print("They should make the world a better place!");
    }
}