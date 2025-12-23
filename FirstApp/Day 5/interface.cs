interface IPrint
{
    void Print();
    void Scan();
}

class Report : IPrint
{
    public void Print()
    {
        Console.WriteLine("Printing report");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning report");
    }
}