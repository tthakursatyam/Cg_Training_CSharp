namespace sales
{
    static class Customers
    {
        public int customer_id{get;set;}
        public string first_name{get;set;}
        public string last_name{get;set;}
        public long number{get;set;}
        public string email{get;set;}
        public string city{get;set;}
        public string state{get;set;}
        public long zip_codes{get;set;}
        public List<Orders>? Orders { get; set; }
    }
    static class Orders
    {
        public int order_id{get;set;}
        public int customer_id{get;set;}
        public int StoreId { get; set; }
        public int StaffId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime Required_Date { get; set; }
        public DateTime Shipped_Date { get; set; }

        public Customers? customer {get;set;}
        public Staffs? staffs {get;set;}
        public Store? store {get;set;}
        public List<Order_Item> order_Items {get;set;}
    }
    static class Staffs
    {
        public int staff_id{get;set;}
        public int store_id{get;set;}
        public int manager_id{get;set;}
        public string first_name{get;set;}
        public string last_name{get;set;}
        public string email{get;set;}
        public long phone{get;set;}
        public string active {get;set;}

        public Staffs Manager { get; set; }
        public List<Orders> orders {get;set;}
        public List<Staffs> Subordinates { get; set; }
        public Store stores {get;set;}

    }
    static class Store
    {
        public int stored_id{get;set;}
        public string stored_name{get;set;}
        public string email{get;set;}
        public string street{get;set;}
        public string state{get;set;}
        public string city{get;set;}
        public long phone{get;set;}
        public long zip_codes{get;set;}

        public List<Staffs> staffs {get;set;}
        public List<Orders> orders {get;set;}
    }
    static class Order_Item
    {
        public int order_id{get;set;}
        public int item_id{get;set;}
        public int product_id{get;set;}
        public int quantity{get;set;}
        public int list_price{get;set;}
        public int discount{get;set;}

        public Orders Order { get; set; }
    }

}