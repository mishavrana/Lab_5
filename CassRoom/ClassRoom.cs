using System.Reflection.Metadata;

namespace Lab_5;

public class ClassRoom
{
    private Pupil? firstPupil;
    private Pupil? secondPupil;
    private Pupil? thirdPupil;

    
    // Constructor for two pupils
    public ClassRoom
        (
            Pupil? firstPupil = null, 
            Pupil? secondPupil = null
        )
    {
        this.firstPupil = firstPupil;
        this.secondPupil = secondPupil;
    }
    
    // Constructor for three pupils
    public ClassRoom
    (
        Pupil? firstPupil = null, 
        Pupil? secondPupil = null,
        Pupil? thirdPupil = null
    )
    {
        this.firstPupil = firstPupil;
        this.secondPupil = secondPupil;
        this.thirdPupil = thirdPupil;
    }
    
    // Method to determine the type
    public void TellAboutTheClass()
    {
        if (firstPupil != null)
        {
            Console.WriteLine($"{firstPupil!.Status} student: ");
            firstPupil!.Read();
            firstPupil!.Relax();
            firstPupil!.Write();
            firstPupil!.Study();
            Console.WriteLine();
        }
        
        if (secondPupil != null)
        {
            Console.WriteLine($"{secondPupil!.Status} student: ");
            secondPupil!.Read();
            secondPupil!.Relax();
            secondPupil!.Write();
            secondPupil!.Study();
            Console.WriteLine();
        }
        
        if (thirdPupil != null)
        {
            Console.WriteLine($"{thirdPupil!.Status} student: ");
            thirdPupil!.Read();
            thirdPupil!.Relax();
            thirdPupil!.Write();
            thirdPupil!.Study();
            Console.WriteLine();
        }
        
    }
}