namespace Lab_5;

public class ExellentPupil: Pupil 
{
    public override string Status
    {
        get { return "Excellent"; }
    }
    override public void Study()
    {
        Console.WriteLine("The student studies for 8 hours");
    }

    override public void Read()
    {
        Console.WriteLine("The student reads William Shakespeare");
    }

    override public void Write()
    {
        Console.WriteLine("The student wrights sentences");
    }

    override public void Relax()
    {
        Console.WriteLine("The student meditates");
    }
}