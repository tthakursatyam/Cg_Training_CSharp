using System;
class Shipment
{
    public string ShipmentCode{get; set;}
    public string TransportMode{get; set;}
    public double Weight{get; set;}
    public int StorageDays{get; set;}

}
class ShipmentDetails : Shipment
{
    public bool ValidateShipmentCode()
    {
        if(ShipmentCode.Length==7)
        {
            string str=ShipmentCode.Substring(0,3);
            if(str=="GC#") return true;
            return false;
        }
        return false;
    }
    public double CalculateTotalCost()
    {
        double RatePerKg=0;
        if(TransportMode=="Sea") RatePerKg=15;
        else if(TransportMode=="Air") RatePerKg=50;
        else if(TransportMode=="Land") RatePerKg=25;
        return Math.Round((Weight*RatePerKg + Math.Sqrt(StorageDays)),2);
    }

}