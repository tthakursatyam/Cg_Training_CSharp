using System;
class Porgram
{
    static SaleTransaction saletrans = new SaleTransaction();
    static bool HasLastTransaction=false;
    public static void Main()
    {
        int choice=0;
        while(choice!=4)
        {
            Console.WriteLine("1.Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2.View Last Transaction");
            Console.WriteLine("3.Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4.Exit");
            
            Console.Write("Enter your choice: ");
            choice=Convert.ToInt32(Console.ReadLine());

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
                    break;
            }
        }
    }
    public static void  NewTransaction()
    {
        string invoice,CustName,ItName;
        int quant;
        double Pamt,Samt;
        Console.Write("Enter Invoice Number: ");
        invoice=Console.ReadLine();
        if(string.IsNullOrWhiteSpace(invoice))
        {
            Console.WriteLine("Please enter correct invoice no");
            return;
        }
        Console.Write("Enter Customer name: ");
        CustName=Console.ReadLine();
        Console.Write("Enter Item name: ");
        ItName=Console.ReadLine();
        Console.Write("Enter Purchase amount: ");
        Pamt = Convert.ToDouble(Console.ReadLine());
        if(Pamt<=0)
        {
            Console.WriteLine("Purchase Amount cannot be 0 or less than 0");
            return;
        }
        Console.Write("Enter quantity of purachased item: ");
        quant = Convert.ToInt32(Console.ReadLine());
        if(quant<=0)
        {
            Console.WriteLine("Quantity cannot be 0 or less than 0");
            return;
        }

        Console.Write("Enter Selling Amount: ");
        Samt=Convert.ToInt32(Console.ReadLine());
        if(Samt<=0)
        {
            Console.WriteLine("Selling Amount cannot be 0 or less than 0");
            return;
        }

        

        saletrans = new SaleTransaction()
        {
            InvoiceNo=invoice,CustomerName=CustName,
            PurchaseAmount=Pamt,Quantity=quant,ItemName=ItName,SellingAmount=Samt
        };

        HasLastTransaction=true;
        Console.WriteLine("\t\t--New Transaction is added---");
    }
    public static void LastTransaction()
    {
        if (HasLastTransaction)
        {
            Console.WriteLine("\t\tHere is your last transaction details\t\t");
            Console.WriteLine("invoice no: "+saletrans.InvoiceNo);
            Console.WriteLine("Customer name: "+saletrans.CustomerName);
            Console.WriteLine("Item Purchased: "+saletrans.ItemName);
            Console.WriteLine("Product Selling Price: "+saletrans.SellingAmount);
            Console.WriteLine("Product Purchase Amount: "+saletrans.PurchaseAmount);
            Console.WriteLine("Quantity: "+saletrans.Quantity);

        }
        else
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
        }
    }
    public static void Calculate()
    {

        string status;
        double PLamt=0;
        double Profitper = (saletrans.SellingAmount-saletrans.PurchaseAmount)*100/saletrans.PurchaseAmount;
        if(saletrans.SellingAmount>saletrans.PurchaseAmount)
        {
            status="PROFIT";
            PLamt=(saletrans.SellingAmount-saletrans.PurchaseAmount)*saletrans.Quantity;
        }
        else if(saletrans.PurchaseAmount>saletrans.SellingAmount)
        {
            status="LOSS";
            PLamt=(saletrans.PurchaseAmount-saletrans.SellingAmount)*saletrans.Quantity;
        }
        else
        {
            status="BREAK-EVEN";
            PLamt=0;
        }

        
        saletrans.ProfitOrLossStatus=status;
        saletrans.ProfitOrLossAmount=PLamt;
        saletrans.ProfitMarginPercent =Profitper;
        

        Console.WriteLine("Status of last transaction: "+saletrans.ProfitOrLossStatus);
        Console.WriteLine($"Total {saletrans.ProfitOrLossStatus}:");
        Console.WriteLine("Percentage of profit: "+saletrans.ProfitMarginPercent);
    }
    
}