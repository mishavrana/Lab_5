using System.Diagnostics;

namespace Lab_5;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DocumentWorker? texter;
        // the path to a file
        AccessLevel accessLevel = getAccessLevel();
        switch (accessLevel)
        {
            case AccessLevel.Pro:
                texter = new ProDocumentWorker();
                while (true)
                {
                    texterOnProAccess((ProDocumentWorker)texter);
                }
            case AccessLevel.Expert:
                texter = new ExpertDocumentWorker();
                while (true)
                {
                    texterOnExpertAccess((ExpertDocumentWorker)texter);
                }
            case AccessLevel.Base:

                texter = new DocumentWorker();
                while (true)
                {
                    texterOnBaseAccess(texter);
                }
        }
    }

    private static AccessLevel getAccessLevel()
    {
        string? key = null;
        Console.WriteLine("Enter the key: ");
        while (key == null)
        {
            key = Console.ReadLine()!;
        }

        if (key == Keys.ProKey)
        {
            return AccessLevel.Pro;
        }

        if (key == Keys.ExpertKey)
        {
            return AccessLevel.Expert;
        }

        return AccessLevel.Base;
    }

    private static void texterOnBaseAccess(DocumentWorker texter)
    {
        string? task = null;

        Console.WriteLine();
        Console.WriteLine("You can open files");
        Console.WriteLine("Choose operation: o - open file/e - edit files/s - change format");
        while (true)
        {
            task = Console.ReadLine()!;
            if (task == "o")
            {
                break;
            }
        }
        texter.OpenDocument();
    }

    private static void texterOnProAccess(ProDocumentWorker texter)
    {
        string? task = null;

        Console.WriteLine();
        Console.WriteLine("You can open and edit files");
        Console.WriteLine("Choose operation: o - open file/e - edit files/s - change format");
        while (true)
        {
            task = Console.ReadLine()!;
            if (task == "o" || task == "e")
            {
                break;
            }
        }
        switch (task)
            {
                case "o":
                    texter.OpenDocument();
                    break;
                case "e":
                    texter.EditDocument();
                    break;
            }
    }

    private static void texterOnExpertAccess(ExpertDocumentWorker texter)
    {
        string? task = null;

        Console.WriteLine();
        Console.WriteLine("You can open and edit and change files' format ");
        Console.WriteLine("Choose operation: o - open file/e - edit files/s - change format");
        while (true)
        {
            task = Console.ReadLine()!;
            if (task == "o" || task == "e" || task == "s")
            {
                break;
            }
        }
        switch (task)
            {
                case "o":
                    texter.OpenDocument();
                    break;
                case "e":
                    texter.EditDocument();
                    break;
                case "s":
                    texter.SaveDocument();
                    break;
            }
    }

}
