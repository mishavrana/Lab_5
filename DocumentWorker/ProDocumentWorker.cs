using System.Runtime.CompilerServices;

namespace Lab_5;

public class ProDocumentWorker: DocumentWorker
{
    public override void EditDocument()
    {
        List<string> lines = File.ReadAllLines(FilePath).ToList();
        string entrie;
        
        switch (overrideLines()) // Checks if the user wants to override the file
        {
            case true:
                Console.WriteLine("Enter the lines to override with ';' separator");
                entrie = Console.ReadLine()!;
                lines = entrie.Split(';').ToList(); // List of lines to add to file
                File.WriteAllLines(FilePath, lines); // Replacing all lines in the text
                break;

            case false: 
                Console.WriteLine("Enter lines to add ';' separator");
                entrie = Console.ReadLine()!;
                lines = entrie.Split(';').ToList(); // List of lines to add to file
                File.AppendAllLines(FilePath, lines);
                break;
        }
        Constants.makeRetreat();
        Console.WriteLine("Документ відредаговано");
        FilePath = enterPath();
    }

    public override void SaveDocument()
    {
        Console.WriteLine
            (
                "Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт"
            );
    }
    
    // Funtion to chose between adding a line or overriding the file
    static bool overrideLines()
    {
        string answer;
        while (true)
        {
            Console.WriteLine("Do you want to override the file? y/n: ");
            answer = Console.ReadLine()!;
            if (answer == "y" || answer == "n")
            {
                break;
            }
        }
        switch (answer)
        {
            case $"y":
                return true; 
            case "n":
                return false;
        }

        throw new InvalidOperationException();
    }
}