namespace Lab_5;

public class GoodPupil: Pupil
{
    public override string Status
    {
        get { return "Good"; }
    }
    public override void Study()
    {
        Console.WriteLine("The student studies for 4 hours");
    }

    public override void Read()
    {
        Console.WriteLine("The student reads fairy tales");
    }

    public override void Write()
    {
        Console.WriteLine("The student writes words");
    }

    public override void Relax()
    {
        Console.WriteLine("The student plays football"); 
    }
}