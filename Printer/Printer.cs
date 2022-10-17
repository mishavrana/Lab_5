namespace Lab_5;

public class Printer
{
    /*
     * This method is 'virtual' to provide the ability to change it's functionality.
     * As example it can be overriden to output information in different colors.
     */
    
    public virtual void Print(string value)
    {
        Console.WriteLine(value);
    }
}