namespace Lab_5;

public class Pupil
{
    public virtual string Status
    {
        get { return "some status"; }
    }
    public virtual void Study() { }
    public virtual void Read() { }
    public virtual void Write() { }
    public virtual void Relax() { }
}