namespace Lab_5;

public class ColourfulPrinter : Printer
{
    private ConsoleColor[] colors = new[]
    {
        ConsoleColor.Blue,
        ConsoleColor.Cyan,
        ConsoleColor.Green,
        ConsoleColor.Magenta,
        ConsoleColor.Red,
        ConsoleColor.Yellow,
        ConsoleColor.White,
    };
        
     // We use override of the original implementation to output the 'value' in different colors.
     public override void Print(string value)
    {
        Random random = new Random();
        int randomIndexForForeground = random.Next(0, colors.Length);
        int randomIndexForBackground = random.Next(0, colors.Length);
        Console.ForegroundColor = colors[randomIndexForBackground];
        Console.WriteLine(value);
    }
}