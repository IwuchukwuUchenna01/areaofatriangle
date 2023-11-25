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

//using colors;
using System.Collections.Generic;
using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace FoodStore
{

    public class FoodDelivery
    {
        //Field
        public class CustomerInfo
        {
            public string? Name { get; set; }
            public string? Address { get; set; }

            public int NumItem { get; set; }

            public string[]? Goods { get; set; }




        }
        ~FoodDelivery()
        {
            Console.WriteLine("Program exited with a destructor");
        }


        //use of records to outline the list of things purchased by each customer to be delivered 
        public record Banks
        {
            public required string bank { get; set; }

            public required double accountNumber { get; set; }

            public required int id { get; set; }


        };

        public List<CustomerInfo> customers = new List<CustomerInfo>() {
                new CustomerInfo(){ Name = "jude", Address = "ilupeju", NumItem =34  },
                new CustomerInfo(){Name = "james", Address = "surulere", NumItem =3},
                new CustomerInfo(){Name = "okonkwo", Address = "ibadan", NumItem =17},
                new CustomerInfo(){Name = "okoro", Address = "ilupeju", NumItem =3},

                };
        public List<Banks> banked = new List<Banks>() {
                new Banks(){ id = 0, bank = "AcessBank",  accountNumber = 081975643647},
                new Banks(){id = 1, bank = "Uba", accountNumber = 099876548976 },
                new Banks(){id = 2, bank = "wema", accountNumber = 4567876543},

                };

        //int j;

        public enum AvailableProducts
        {
            food, drinks,
        }
        public enum PaymentForDelivery
        {
            onDelivery, beforeDelivery,
        }
        public enum banks
        {
            access, uba, wema
        }
        // Parameterized Constructor
        public FoodDelivery(string Name = "jude", string Address = "Ilupeju")
        {
            CustomerInfo customer = new CustomerInfo();
            Console.Write("enter your Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("enter your address: ");
            string address = Convert.ToString(Console.ReadLine());
            Console.Write($"Select The method of payment Most Prefered, Mr {name}:\n ondelivery or beforeDelivery(0 or 1)? ");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"kindly confirm if {address} is your address");
            Console.Write("yes or no: ");
            var entry = Convert.ToString(Console.ReadLine());
            string[] banksToPayToBeforeDelivery = { "AccessBank", "UbaBank", "Wema Bank" };
            foreach (var item in customers)
            {
                //Console.WriteLine(item.Name);
                if (entry == "yes")
                {
                    if (item.Name == name && item.Address == address)
                    {
                        Console.WriteLine($"number of items purchased:{item.NumItem}");
                        Console.WriteLine($"your items will be shipped to  the following address: no 16 wema bank {address}");

                        if (m == (int)PaymentForDelivery.beforeDelivery)
                        {

                            Console.WriteLine("select the account you wish to pay to");

                            int count = 0;
                            foreach (var item2 in banksToPayToBeforeDelivery)
                            {
                                Console.WriteLine($"{count++} {item2}");
                            }
                            //count++;
                            var y = Convert.ToInt32(Console.ReadLine());
                            foreach (var item1 in banked)
                            {
                                if (y == item1.id)
                                {
                                    Console.WriteLine($"{item1.bank}: {item1.accountNumber}");
                                };

                                //if (item1.bank == banks.) {
                                //Console.WriteLine({item1.accountNumber});
                                ;
                            };
                        }

                    }
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

            /*states states = new states();
            Console.WriteLine(states.param());*/
        }
    }
}





