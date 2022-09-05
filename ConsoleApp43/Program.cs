Printer printer = new Printer();
printer.Print("example");

PrinterYellow printYell = new PrinterYellow();
printYell.Print("example");
class Printer
{ public void Print(string value)
        {
            Console.WriteLine(value);
        }
}
class PrinterYellow : Printer
{
    public void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.Print(value);
    }
}
