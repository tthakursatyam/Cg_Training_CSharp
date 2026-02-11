namespace DLL;

interface I1
{
    void M1();
    void M2();
}
public class A:I1
{
    public void M1()
    {
        Console.WriteLine("M1");
    }
    public void M2()
    {
        Console.WriteLine("M2");
    }
}
