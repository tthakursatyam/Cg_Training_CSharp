using System;
class Computer
{
    public string Processor {get;set;}
    public int RamSize {get;set;}
    public int HardDiskSize {get;set;}
    public int GraphicCard {get;set;}
}
class Desktop : Computer
{
    public int MonitorSize {get;set;}
    public int PowerSupplyVolt {get;set;}
    public double DesktopPriceCalculation()
    {
        int ProcessorCost=0;
        if(Processor=="i3") ProcessorCost=1500;
        else if(Processor=="i5") ProcessorCost=3000;
        else if(Processor=="i7") ProcessorCost=4500;
        return (ProcessorCost + (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + (MonitorSize*250)+(PowerSupplyVolt*20))*1.0;

    }
}
class Laptop : Computer
{
    public int DisplaySize {get;set;}
    public int BatteryVolt {get;set;}   

    public double LaptopPriceCalculation()
    {
        int ProcessorCost=0;
        if(Processor=="i3") ProcessorCost=2500;
        else if(Processor=="i5") ProcessorCost=5000;
        else if(Processor=="i7") ProcessorCost=6500;
        return (ProcessorCost + (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + (DisplaySize*250))*1.0+(BatteryVolt*20);
    }
}