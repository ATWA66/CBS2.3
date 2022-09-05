ExcelentPupil Kostya = new ExcelentPupil();
GoodPupil Sasha = new GoodPupil();
BadPupil Robert = new BadPupil();
ClassRoom oneB = new ClassRoom(Robert, Sasha, Kostya);
Console.WriteLine("student # 1:");
oneB.one.Read();
oneB.one.Write();
oneB.one.Relax();
oneB.one.Study();
Console.WriteLine("student # 2:");
oneB.two.Read();
oneB.two.Write();
oneB.two.Relax();
oneB.two.Study();
Console.WriteLine("student # 3:");
oneB.three.Read();
oneB.three.Write();
oneB.three.Relax();
oneB.three.Study();
Console.WriteLine("student # 4:");
oneB.four.Read();
oneB.four.Write();
oneB.four.Relax();
oneB.four.Study();

class ClassRoom
{
    public Pupil one = new Pupil();
    public Pupil two = new Pupil();
    public Pupil three = new Pupil();
    public Pupil four = new Pupil();
   public ClassRoom(Pupil one, Pupil two, Pupil three, Pupil four)
    {
        this.one = one;
        this.two = two;
        this.three = three;
        this.four = four;
    }
    public ClassRoom(Pupil one, Pupil two)
    {
        this.one = one;
        this.two = two;
    }
    public ClassRoom(Pupil one, Pupil two, Pupil three)
    {
        this.one = one;
        this.two = two;
        this.three = three;
    }
}
class Pupil
{
    virtual public void Study()
    {
        Console.WriteLine("Just learning...");
    }
    virtual public void Read() 
    {
        Console.WriteLine("Just reading...");
    }
    virtual public void Write()
    {
        Console.WriteLine("Just writing...");
    }
    virtual public void Relax()
    {
        Console.WriteLine("Just relaxing...");
    }

}
class ExcelentPupil : Pupil
{
    override public void Study()
    {
        Console.WriteLine("Learning as nerd...");
    }   
    override public void Read()
    {
        Console.WriteLine("Reading as nerd...");
    }    
    override public void Write()
    {
        Console.WriteLine("Writing as nerd...");
    }   
    override public void Relax()
    {
        Console.WriteLine("Relaxing as nerd...");
    }
}
class GoodPupil : Pupil 
{
    override public void Study()
    {
        Console.WriteLine("Learning as normal...");
    }
    override public void Read()
    {
        Console.WriteLine("Reading as normal...");
    }
    override public void Write()
    {
        Console.WriteLine("Writing as normal...");
    }
    override public void Relax()
    {
        Console.WriteLine("Relaxing as normal...");
    }
}
class BadPupil : Pupil
{
    override public void Study()
    {
        Console.WriteLine("Learning as bully...");
    }
    override public void Read()
    {
        Console.WriteLine("Reading as bully...");
    }
    override public void Write()
    {
        Console.WriteLine("Writing as bully...");
    }
    override public void Relax()
    {
        Console.WriteLine("Relaxing as bully...");
    }
}
