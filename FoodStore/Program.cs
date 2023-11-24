//namespace System.Collections.Generic;

//A sysmple program outlining the things that a class can contain 
/*
     field
    interface
    internal and external Constructor
    Destructor
    Delegate
    enum
 */

using System.Security.Cryptography.X509Certificates;

namespace FoodStore
{

    public class FoodDelivery
    {
        //Field
        public class CustomerInfo {
            public string? Name { get; set; } = "jude";
            public string? Address { get; set; }

            public int NumItem { get; set; }

            public string[]? Goods { get; set; }




        }
        ~FoodDelivery(){
            Console.WriteLine("Program exited with a destructor");
        }


        //use of records to outline the list of things purchased by each customer to be delivered 
        public record purchesItem
        {
            public required string drinks { get; set; }

            public required string food { get; set; }


        };
        
        public List<CustomerInfo> customers = new List<CustomerInfo>() {
                new CustomerInfo(){ Name = "jude", Address = "ilupeju", NumItem =34 },
                new CustomerInfo(){Name = "james", Address = "surulere", NumItem =3},
                new CustomerInfo(){Name = "okonkwo", Address = "ibadan", NumItem =17},
                new CustomerInfo(){Name = "okoro", Address = "ilupeju", NumItem =3},

                };

        //int j;

        public enum AvailableProducts
        {
            food, drinks,
        }
        // Parameterized Constructor
        public FoodDelivery(string Name = "jude", string Address = "Ilupeju")
        {
            CustomerInfo customer = new CustomerInfo();
            Console.Write("enter your Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("enter your address: ");
            string address = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Select The method of delivery Most Prefered, Mr {name}: kindly confirm if {address} is your address");
            Console.Write("yes or no: ");
            var entry = Convert.ToString(Console.ReadLine());
            foreach (var item in customers)
            {
                //Console.WriteLine(item.Name);
                if (entry == "yes")
                {
                        if (item.Name == name) {
                            Console.WriteLine($"number of items purchased:{item.NumItem}");
                            Console.WriteLine($"your items will be shipped to  the following address: no 16 wema bank {address}");
                        };
                    

                }
            }
            

        }

        //public delegate void 
        interface ICustomer
        {

            string Name { get; set; }
            string Address { get; set; }
        }

        public static void Main(string[] args)
        {
            //internal constructor
            FoodDelivery DeliveryMethod = new FoodDelivery();
            CustomerInfo CustomerInfo = new CustomerInfo();
            Console.WriteLine((int)AvailableProducts.drinks);
            Console.WriteLine(CustomerInfo.NumItem);
            // purchesItem itemspurchased = new purchesItem()
        }
    }
}




