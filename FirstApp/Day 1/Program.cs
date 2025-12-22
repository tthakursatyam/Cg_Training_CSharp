using System;
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

        BankAccount bnk = new BankAccount(2049,10);
        bnk.Deposit(99);
        bnk.getBalance();
        bnk.Withdraw(55);
        bnk.getBalance();
    }
}