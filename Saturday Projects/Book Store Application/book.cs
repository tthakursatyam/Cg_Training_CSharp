namespace Book_Store_Application
{
    class Book
    {
        public string Id {get;set;}
        public string Title {get;set;}
        public string Author {get;set;}
        public int Price {get;set;}
        public int Stock{get;set;}

        public void GetBookDetails()
        {
            Console.WriteLine($"Details: {Id} {Title} {Price} {Stock}");
        }
        public void UpdateBookPrice(int newPrice)
        {
           Price = newPrice;
           Console.WriteLine($"Updated Price: {Price}");
        }
        public void UpdateBookStock(int newStock)
        {
           Stock = newStock;
           Console.WriteLine($"Updated Stock: {Stock}");
        }
    }

}