namespace Lab_5;
using System.IO;
public class DocumentWorker
{
    private string filePath = enterPath();

    public string FilePath
    {
        get { return filePath; }
        set { filePath = value; }
    }
    
    public virtual void OpenDocument()
    {
        List<string> lines = File.ReadAllLines(FilePath).ToList();

        Constants.makeRetreat();
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
        Constants.makeRetreat();
        Console.WriteLine("Документ відкритий");
        FilePath = enterPath();
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Правка документа доступна у версії Про");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Збереження документа доступне у версії Про");
    }

    public static string enterPath()
    {
        Console.WriteLine("Enter the path to the file");
        while (true)
        {
            string filePath = Console.ReadLine()!;
            if (File.Exists(filePath))
            {
                return filePath;
            } 
            Console.WriteLine("Not valid path!");
        }
    }
}