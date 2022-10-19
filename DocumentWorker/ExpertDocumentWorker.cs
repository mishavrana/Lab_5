using System.Security.Cryptography;

namespace Lab_5;

public class ExpertDocumentWorker: ProDocumentWorker
{
    public override void SaveDocument()
    {
        Formats format = chooseFormat();
        switch ( format )
        {
           case Formats.Pdf: 
               File.Move(FilePath, Path.ChangeExtension(FilePath, ".pdf"));
               break;
           case Formats.Docx:
               File.Move(FilePath, Path.ChangeExtension(FilePath, ".docx"));
               break;
           case Formats.Txt:
               File.Move(FilePath, Path.ChangeExtension(FilePath, ".txt"));
               break;
        }
        Constants.makeRetreat();
        Console.WriteLine("Документ збережений в новому форматі");
        FilePath = enterPath();
    }

    static Formats chooseFormat()
    {
        string fileFormat; 
        while (true)
        {
            Console.WriteLine("Choose the format to change in: /txt/pdf/docx");
            fileFormat = Console.ReadLine()!;
            if (fileFormat == "txt" || fileFormat == "pdf" || fileFormat == "docx")
            {
                break; 
            }
        }
        switch (fileFormat)
        {
            case "txt":
                return Formats.Txt;
            case "pdf":
                return Formats.Pdf; 
            case "docx":
                return Formats.Docx;
        }

        throw new InvalidOperationException();
    }
}