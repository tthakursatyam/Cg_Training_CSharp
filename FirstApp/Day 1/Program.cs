using System;
using System.Text.RegularExpressions;
using LI= LibrarySystem.Items;
using LU= LibrarySystem.Users;
class Program
{
    static void Main()
    {
        //Console.Beep();
        
        //  ***to calculate Area***
        //AOC.Area();

        //  ***to convert given length in CM from feet***
        //Conversion.FtoCM();

        //  ***to convert given Seconds in Minutes***
        //Con.StoM();

        //  *** Conditional Statement***
        //Conditions.Condition();

        //  *** Odd Even ***
        //OE.OddEven();

        // *** eligibility for DL using If else ***
        //DL.Dl();

        // *** largest number among 3 numbers ***
        //Large.Largest();

        //*** sum of digits using while loop ***
        //Sum.OfDigits();

        //*** reverse a digit ***
        //Rev.erse();
        
        
        //          **** day 2     ****
        
        //  *** Do While loop ***
        // Do.Whle();

        //  ***Multiplication table of 21 to 30 ***
        // Multiplication.Example2();

        //  ***Small Game using For Loop***
        // Game.Example1();

        //  ***   Loan Eligibility,Tax Calculation,Transactions     ***
        // Finance.Manage();

        //       *** Credit And Debit department features           ***
        // Bank.Credit_Debit();

        


        //          **** day 3     ****

        // Employee emp1 = new Employee();
        // emp1.name="Satyam Singh";
        // emp1.salary=10;

        // emp1.DisplayDetails();


        // BankAccount bank1 =  new BankAccount();
        // bank1.Accno=20492737044;
        // bank1.Balance=50;
        // bank1.GetBalance();
        // bank1.Deposit(50);
        // bank1.GetBalance();



        // Wallet wallet = new Wallet();
        // wallet.setmoney(100);
        // Console.WriteLine($"Your Bank Balance: {wallet.getBalance()};");
        // wallet.AddMoney(50);
        // Console.WriteLine($"Your Bank Balance: {wallet.getBalance()};");



        // Overloading overloading = new Overloading();
        // Console.WriteLine(Overloading.add(1,3));
        // Console.WriteLine(overloading.add(1.2,3.5));



        // Named named = new Named();
        // named.person(age:22,name:"Satyam Singh",city:"Varanasi");

        // DF df = new DF();
        // df.person(name:"Satyam Singh",age:22,gender:"M");


        // Para para = new Para();
        // para.ms(1,2,3,4,3);
        // //para.ms(1,2,{3,4,6,7});
        //para.ms(1,2,3,4.5,6.7);


        // int x=20;
        // Pass pass = new Pass();
        // pass.value(x);
        // Console.WriteLine($"Pass by value: {x}");
        // pass.refer(ref x);
        // Console.WriteLine($"Pass by reference: {x}");


        //Ou ou = new Ou();
        // int q,r;
        // ou.divide(10,3,out q,out r);
        // Console.WriteLine("Quotient: " + q);
        // Console.WriteLine("Remainder: " + r);
        // int n=50;
        // ou.show(in n);



        // LoGlo obj1 = new LoGlo();
        // obj1.calculator(20,10);

        //example.ex();
        //Test.Calculate();

        //ex.eg(4.3);

        // BankAccountt bnk = new BankAccountt(2049,10);
        // bnk.Deposit(99);
        // bnk.getBalance();
        // bnk.Withdraw(55);
        // bnk.getBalance();

        //          **** Day 4 *****


                    //Constructors
        //Constr con = new Constr(5);
        //constr2 con2 = new constr2();

                    // basic example of inheritance  ****
        // FD obj1 = new FD(100,10);
        // obj1.display();
        // obj1.bnk();

        
                    //Object Initializer  
        //works only when default constructor is available
        //It can only intialize private member
        //Product p = new Product{Name = "Laptop",Price = 50000};

        
                //          **** Properties      ****
        // person1 p1=new person1();
        // p1.Age=20;
        // Console.WriteLine(p1.Age);

        // StudentPrf st = new StudentPrf();
        // st.Age=22;
        // st.Name="Satyam Singh";
        // st.Marks=93;
        // Console.WriteLine("Name:"+st.Name);
        // Console.WriteLine("Age:"+st.Age);
        // Console.WriteLine("Marks:"+st.Marks);

    
        //          ***Advance uses of properties*** 
        // adv_prop obj1 = new adv_prop();
        // obj1.Age=21;
        // Console.WriteLine("Age:"+obj1.Age);
        // obj1.StudentID=123;
        // Console.WriteLine("StudentID:"+obj1.StudentID);
        // Console.WriteLine(obj1.Marks);
        // obj1.Password="sfhbsjids";
        // obj1.Name="Satyam Singh";
        // Console.WriteLine("Name:"+obj1.Name);

                    //indexer
        // Stucoll obj = new Stucoll();
        // obj[0]="Satyam";
        // Console.WriteLine(obj[0]);

                //Indexer Overloading
        // EmployeeDirectory ed = new EmployeeDirectory();
        // ed[101] = "Ravi";
        // Console.WriteLine(ed[101]);
        // Console.WriteLine(ed["Satyam"]);


                //LMS using indexer overloading

         
        // LMS lms = new LMS();
        // lms[0]="Physics";
        // lms[1]="Maths";
        // lms[13]="Chemistry";
        // Console.WriteLine(lms[0]);
        // Console.WriteLine(lms["Maths"]);
        // Console.WriteLine(lms[16]);



                //inheritance
        // student st = new student(44,"Satyam");
        // Console.WriteLine(st.name);
        // Console.WriteLine(st.rollno);


                // multi level inheritance
        // Department depart = new Department("Btech",44,"Satyam");
        // Console.WriteLine(depart.name);
        // Console.WriteLine(depart.rollno);
        // Console.WriteLine(depart.de);

                //Interface
        // Machine mh = new Machine();
        // mh.Print();
        // mh.Scan();


                //Overriding
        // Dog dg = new Dog();
        // dg.Sound();
        // Animal an =new Animal();
        // an.Sound();

        // Car cr = new Car();
        // cr.Drive();



                    //****insurance management system****
        // Security sc = new Security("admin123");
        // life_inusrance inp= new life_inusrance(1234,100);
        // inp.premium=10000;
        // inp.policyholdername="Satyam";
        // inp.insurance_premium();
        // inp.display();




                /////****       Day 5             *****///////
        
        // Report rp = new Report();
        // rp.Print();
        // rp.Scan();

                        //*** LMS Project ***//

                //Task 1
        
        // LI.Book bk = new LI.Book();
        // bk.Title="Physics";
        // bk.Author="HC Verma";
        // bk.ItemID=1234;
        // bk.DaysLate=3;
        // bk.display();
        // bk.late_fee();

                //Task 2
        // LI.Book bk2 = new LI.Book();
        // bk2.reserve();
        // bk2.msg("My message");


        //         //Task 4
        // LI.IReservable task4 = new LI.Book();
        // task4.reserve();
        // task4.msg("Message");

        // LI.INotifiable tsk4 = new LI.Book();
        // tsk4.reserve();
        // task4.msg("Message");


        //         //Task 6
        // LU.LibraryAnalytics.Display();

        //         //Task 7
        // LU.Member tsk7 = new LU.Member();
        // tsk7.display();



                        //****          Day 6           //

        // StockPrice original = new StockPrice{ 
        //         Stock_Symbol="TCS",
        //         Price=155.5
        //         };

        // StockPrice copied = original;
        // copied.Price=1555;
        // Console.WriteLine("Original: "+original.Stock_Symbol+original.Price);
        // Console.WriteLine("Copied: "+copied.Stock_Symbol+copied.Price);

        // Trade origin = new Trade
        // {
        //         Trade_ID=123,
        //         Stock_Symbol="TCS",
        //         Quantity = 200
        // };
        // Trade copy = origin;
        // Trade copy1 = new Trade();
        // copy1.Quantity=50;
        // copy.Quantity=100;
        
        // Console.WriteLine($"Origi: {origin.Stock_Symbol} {origin.Quantity} {origin.Trade_ID}");
        // Console.WriteLine($"Copy: {copy.Stock_Symbol} {copy.Quantity} {copy.Trade_ID}");



        // Portfolio p1 = new Portfolio { Name = "Growth" };
        // Portfolio p2 = new Portfolio { Name = "Growth" };

        // Console.WriteLine(p1.Equals(p2));
        // Console.WriteLine(p1==p2);

        // Console.WriteLine(p1.GetHashCode());
        // Console.WriteLine(p2.GetHashCode());

        
        // day6.Trade t = new day6.EquityTrade();
        // Console.WriteLine(t.GetType());


        // Generic<int> gn = new Generic<int>();
        // gn.SetValue(23);
        // Console.WriteLine("Value: "+gn.GetValue());

        // programm.Mainn();


        // Calculate cl = new Calculate();
        // Console.WriteLine(cl.add(4,5));
        // double db = cl.add(10.4,89.9);
        // Console.WriteLine(db);

        // Calculate c2 = new Calculate();
        // Console.WriteLine(c2.PrintData("egvfsdf"));

        // Person p1 = new Person();
        // p1.name="Satyam";
        // p1.age=22;

        // Console.WriteLine("Name: "+p1.name);
        // Console.WriteLine("Age: "+p1.age);
        
        // Person p2 = new Person { name = "Satyam Singh",age=22};
        
                //*** Boxing and Unboxing ***

        // int n=10;
        // object ob=n;
        // Console.WriteLine("Boxing: "+ob.GetType());
        // int n1 = (int) ob;
        // Console.WriteLine("UnBoxing: "+n1.GetType());

        // object obj = p2;
        // Console.WriteLine("Boxing: "+obj);

        // Person p3 = (Person) obj;
        // Console.WriteLine("UnBoxing: "+p3);   

        // arr11 ar = new arr11(); 
        // ar.eg();

        // hs obj = new hs();
        // obj.hset();

        // freq obj = new freq();
        // obj.func();

        // merge mr = new merge();
        // mr.func();

        //Console.WriteLine(task2.GenerateKey("RamanGoyal"));

        // multid_array obj1 = new multid_array();
        // obj1.func();

                        //      ***Day 9***     //
        // exc_hand.func();

        // Console.WriteLine(Environment.NewLine);

        // BankAcc obj1 = new BankAcc();
        // obj1.Withdraw(1200);
        // obj1.Withdraw(7000);
        // obj1.Withdraw(3800);
        // obj1.Withdraw(120);

        
        // exc_hand obj = new exc_hand();
        // obj.func2();
        

        // BankAcco obj1 = new BankAcco(5000);
        // obj1.Withdraw(-97878);



                //Task Day 9//
        // BankingSystem.BankAccount bnk = new BankingSystem.BankAccount("2049",5000);
        // Console.WriteLine("Balance:"+bnk.balance);
        // bnk.withdraw(9000);






                        //      ***Day 10***    //
        //Reg.func1();
        //Task1.func1();


        LogProcessing.LogParser obj = new LogProcessing.LogParser();
        obj.func1();
     }
}