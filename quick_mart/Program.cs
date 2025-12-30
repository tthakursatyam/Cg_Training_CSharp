using System;
class Porgram
{
    static SaleTransaction saletrans = new SaleTransaction();
    public static void Main()
    {
        Console.WriteLine("1.Create New Transaction (Enter Purchase & Selling Details)");
        Console.WriteLine("2.View Last Transaction");
        Console.WriteLine("3.Calculate Profit/Loss (Recompute & Print)");
        Console.WriteLine("4.Exit");

        int choice=Convert.ToInt32(Console.WriteLine());

        switch(choice)
        {
            case 1:
                NewTransaction();
                break;
            case 2:
                LastTransaction();
                break;
            case 3:
                Calculate();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("You have entered incorrect option");
        }
    }
    public static void  NewTransaction()
    {
        string? invoice,CustName,ItName;
        int quant;
        double Pamt;
        Console.Write("Enter Invoice Number: ");
        invoice=Console.ReadLine();
        Console.WriteLine("Enter Customer name: ");
        CustName=Console.ReadLine();
        Console.WriteLine("Enter Item name: ");
        ItName=Console.ReadLine();
        Console.WriteLine("Enter Purchase amount: ");
        Pamt = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter quantity of purachased item: ");
        quant = Convert.ToInt32(Console.ReadLine());

        saletrans = new SaleTransaction()
        {
            InvoiceNo=invoice,CustomerName=CustName,
            PurchaseAmount=Pamt,Quantity=quant,ItemName=ItName
        };
        Console.WriteLine("\t\t--New Transaction is added---");
    }
    public static void LastTransaction()
    {
        
    }
}