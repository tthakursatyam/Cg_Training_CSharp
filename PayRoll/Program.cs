class Program
{
    static void Main()
    {
        PayrollManager manager = new PayrollManager();
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\n1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RegisterEmployeeFlow(manager);
                    break;

                case 2:
                    ShowOvertimeFlow(manager);
                    break;

                case 3:
                    double avg = manager.CalculateAverageMonthlyPay();
                    Console.WriteLine("Overall average monthly pay: " + avg);
                    break;

                case 4:
                    Console.WriteLine("Logging off — Payroll processed successfully!");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void RegisterEmployeeFlow(PayrollManager manager)
    {
        Console.Write("Select Employee Type (1-Full Time, 2-Contract): ");
        int type = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Hourly Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double bonus = 0;
        if (type == 1)
        {
            Console.Write("Enter Monthly Bonus: ");
            bonus = Convert.ToDouble(Console.ReadLine());
        }

        double[] hours = new double[4];
        Console.WriteLine("Enter weekly hours (Week 1 to 4):");
        for (int i = 0; i < 4; i++)
        {
            hours[i] = Convert.ToDouble(Console.ReadLine());
        }

        EmployeeRecord emp;

        if (type == 1)
        {
            emp = new FullTimeEmployee
            {
                EmployeeName = name,
                HourlyRate = rate,
                MonthlyBonus = bonus,
                WeeklyHours = hours
            };
        }
        else
        {
            emp = new ContractEmployee
            {
                EmployeeName = name,
                HourlyRate = rate,
                WeeklyHours = hours
            };
        }

        manager.RegisterEmployee(emp);
        Console.WriteLine("Employee registered successfully");
    }

    static void ShowOvertimeFlow(PayrollManager manager)
    {
        Console.Write("Enter hours threshold: ");
        double threshold = Convert.ToDouble(Console.ReadLine());

        Dictionary<string, int> result =
            manager.GetOvertimeWeekCounts(PayrollManager.PayrollBoard, threshold);

        if (result.Count == 0)
        {
            Console.WriteLine("No overtime recorded this month");
        }
        else
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
