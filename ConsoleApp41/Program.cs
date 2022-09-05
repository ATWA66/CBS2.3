Vehicle example = new Vehicle();
Plane plane = new Plane();
plane.planeinfo();
Car car = new Car();
car.carinfo();
Ship ship = new Ship();
ship.shipinfo();
class Vehicle
{
    virtual public int price { get; set; }
    virtual public int speed { get; set; }
    virtual public int year { get; set; }
}
class Plane : Vehicle
{
    override public int price { get { return 100000000; } }
    override public int speed { get { return 926; } }
    override public int year { get { return 2022; } }
    public int peopleAmount { get { return 33; } }
    public int flyHight { get { return 9000; } }
    public void planeinfo()
    {
        Console.WriteLine("plane info:");
        Console.WriteLine("price = " + price);
        Console.WriteLine("speed = " + speed);
        Console.WriteLine("year = " + year);
        Console.WriteLine("people amount = " + peopleAmount);
        Console.WriteLine("fly Hight = " + flyHight);
    }
}
class Car : Vehicle
{
    override public int price { get { return 12000; } }
    override public int speed { get { return 380; } }
    override public int year { get { return 2022; } }
    public void carinfo()
    {
        Console.WriteLine("car info:");
        Console.WriteLine("price = " + price);
        Console.WriteLine("speed = " + speed);
        Console.WriteLine("year = " + year);
    }
}
class Ship : Vehicle
{
    override public int price { get { return 150000000; } }
    override public int speed { get { return 37; } }
    override public int year { get { return 2022; } }
    public int peopleAmount { get { return 200; } }
    public string port { get { return "20142288"; } }
    public void shipinfo()
    {
        Console.WriteLine("ship info:");
        Console.WriteLine("price = " + price);
        Console.WriteLine("speed = " + speed);
        Console.WriteLine("year = " + year);
        Console.WriteLine("people amount = " + peopleAmount);
        Console.WriteLine("port = " + port);
    }
}