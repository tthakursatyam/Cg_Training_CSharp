using System;

class Program
{
    static void Main(string[] args)
    {
        IUserRepository repo = new UserRepository();

        string name = repo.GetUserName(1);

        Console.WriteLine("User from real repository: " + name);

        Console.WriteLine("Program executed successfully.");
    }
}