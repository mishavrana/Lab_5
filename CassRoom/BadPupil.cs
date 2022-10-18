namespace Lab_5;

public class BadPupil: Pupil 
{
    public override string Status
    {
        get { return "Bad"; }
    }
    override public void Study()
    {
        Console.WriteLine("The student doesn't study");
    }

    override public void Read()
    {
        Console.WriteLine("The student reads words on the walls");
    }

    override public void Write()
    {
        Console.WriteLine("The student writes symbols");
    }

    override public void Relax()
    {
        Console.WriteLine("The student plays video games");
    }
}