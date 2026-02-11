using System;
class Program
{
    public static void Main()
    {
        ShipmentDetails shipmentdetails = new ShipmentDetails();
        Console.Write("Enter the Shipment Code: ");
        shipmentdetails.ShipmentCode = Console.ReadLine();
        if (!shipmentdetails.ValidateShipmentCode())
        {
            Console.WriteLine("Invalid shipment code");
            return;
        }
        Console.Write("Enter the Transport Mode: ");
        shipmentdetails.TransportMode=Console.ReadLine();
        
        Console.Write("Enter the Weight: ");
        shipmentdetails.Weight=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Storage Days: ");
        shipmentdetails.StorageDays=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The total shipping cost is {shipmentdetails.CalculateTotalCost():F2}");
        
    }
}