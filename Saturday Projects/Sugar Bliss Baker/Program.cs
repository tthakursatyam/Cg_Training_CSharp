using System;
class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Enter Flavour: ");
        string flvr = Console.ReadLine();
        Console.WriteLine("Enter Quantity: ");
        int qu = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Price per unit: ");
        int pp = Convert.ToInt32(Console.ReadLine());

        Chocolate chocolate = new Chocolate
        {
            Flavour=flvr,Quantity=qu,PricePerUnit=pp
        };

        if(chocolate.ValidateChocolateFlavour())    
        {
            CalculateDiscountedPrice(chocolate);
        }
        else
        {
            Console.WriteLine("Invalid flavour");
        }
    }
    public static Chocolate CalculateDiscountedPrice(Chocolate chocolate)
    {
        chocolate.TotalPrice = chocolate.Quantity * chocolate.PricePerUnit;
        int DiscountPercentage=0;
        if(chocolate.Flavour=="Dark") DiscountPercentage=18;
        else if(chocolate.Flavour=="Milk") DiscountPercentage=12;
        else if(chocolate.Flavour=="White") DiscountPercentage=6;
        chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice * DiscountPercentage / 100);

        Console.WriteLine("Flavour: "+chocolate.Flavour);
        Console.WriteLine("Quantity: "+chocolate.Quantity);
        Console.WriteLine("Price Per Unit: "+chocolate.PricePerUnit);
        Console.WriteLine("Total Price: "+chocolate.TotalPrice);
        Console.WriteLine("Discounted price: "+chocolate.DiscountedPrice);
        return chocolate;
    }
}