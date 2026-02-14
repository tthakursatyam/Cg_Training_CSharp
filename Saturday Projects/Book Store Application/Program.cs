namespace Book_Store_Application
{
    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");

            Book book = new Book()
            {
                Id=input[0],Title=input[1],
                Price=Convert.ToInt32(input[2]),
                Stock=Convert.ToInt32(input[3])
            };

            while(true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        book.GetBookDetails();
                        break;
                    case 2:
                        int temp=Convert.ToInt32(Console.ReadLine());
                        book.UpdateBookPrice(temp);
                        break;
                    case 3:
                        int temp2=Convert.ToInt32(Console.ReadLine());
                        book.UpdateBookStock(temp2);
                        break;
                    case 4:
                        Console.WriteLine("Thank You");
                        return;
                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                }
            }
        }
    }
}