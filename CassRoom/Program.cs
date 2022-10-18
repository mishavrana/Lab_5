namespace Lab_5;

class Program
{
    private static ExellentPupil exellentPupil = new ExellentPupil();
    private static GoodPupil goodPupil = new GoodPupil();
    
    static ClassRoom classRoom4B = new ClassRoom(exellentPupil, goodPupil);
    
    static void Main(string[] args)
    {
        classRoom4B.TellAboutTheClass();
    }
}