class Program
{
    public static void Main()
    {
        Console.Write("Enter the System you want (Laptop/Desktop): ");
        string system = Console.ReadLine();

        switch(system)
        {
            case "Desktop":
                Desktop desktop = new Desktop();
                Console.Write("Enter the Processor: ");
                desktop.Processor=Console.ReadLine();

                Console.Write("Enter the Size of Ram(GB): ");
                desktop.RamSize=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Size of Hard Disk(TB): ");
                desktop.HardDiskSize=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Graphic Card(GB): ");
                desktop.GraphicCard=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Monitor Size(Inch): ");
                desktop.MonitorSize=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Power Supply(W): ");
                desktop.PowerSupplyVolt=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Your selected Desktop specs are as: Processor:{desktop.Processor},Ram:{desktop.RamSize},Hard Disk:{desktop.HardDiskSize},Graphic Card:{desktop.GraphicCard},Monitor Size:{desktop.MonitorSize},Power Supply:{desktop.PowerSupplyVolt}");
                Console.Write("Your final payable amount is: "+desktop.DesktopPriceCalculation());
            break;

            case "Laptop":
                Laptop laptop = new Laptop();
                Console.Write("Enter the Processor: ");
                laptop.Processor=Console.ReadLine();

                Console.Write("Enter the Size of Ram(GB): ");
                laptop.RamSize=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Size of Hard Disk(TB): ");
                laptop.HardDiskSize=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Graphic Card(GB): ");
                laptop.GraphicCard=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Display Size(Inch): ");
                laptop.DisplaySize=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Battery Volt(Volt): ");
                laptop.BatteryVolt=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Your selected Desktop specs are as: Processor:{laptop.Processor},Ram:{laptop.RamSize},Hard Disk:{laptop.HardDiskSize},Graphic Card:{laptop.GraphicCard},Monitor Size:{laptop.DisplaySize},Power Supply:{laptop.BatteryVolt}");
                Console.Write("Your final payable amount is: "+laptop.LaptopPriceCalculation());
            break;

            default:
                Console.WriteLine("You have enetered the wrong System.");
            break;
        }
    }
}