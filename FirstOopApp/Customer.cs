using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOopApp
{
    internal class Customer
    {
        private static int nextId = 0;

        private readonly int _id;
        // private or backing fields

        private string _password;

        // public properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int TransactionCount { get; set; }

        // read only property
        public int Id { get { 
                return _id;
            } }

        //write only property
        public string Password { set { _password = value; } }

        // read only property
        // computed property
        public string Status
        {
            get
            {
                if (TransactionCount > 10)
                {
                    return "Your a regular customer";
                }
                else
                {
                    return "You are a new customer";
                }
            }
        }

        // default constructor
        //public Customer()
        //{
        //    FirstName = "No First Name";
        //    LastName = "No Last Name";
        //    Age = 0;
        //    TransactionCount = 0;
        //    Status = "No status";
        //}

        // Default / parameterized constructor
        public Customer(string fName = "EMPTY", string lName = "EMPTY", int age = 0, int transac = 0)
        {
            _id = nextId++;
            FirstName = fName;
            LastName = lName;
            Age = age;
            TransactionCount = transac;

        }


        /// <summary>
        /// Thus method sets the details of the customer after the object has been created
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="age"></param>
        /// <param name="transac"></param>
        /// <param name="status"></param>
        public void SetDetails(string fName = "EMPTY", string lName = "EMPTY", int age = 0, int transac = 0)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            TransactionCount = transac;
        }

        public void GetDetails()
        {
            Console.WriteLine($"The customer has ID {Id} with first name {FirstName} and last name {LastName} has {TransactionCount} transactions");
        }

        // static method are methods that belong to the class and not the object
        // they can be called without creating an object of the class
        //they can only by the class and not the object
        public static void DoSometing()
        {
            Console.WriteLine("I am doing something");
            
        }

    }
}
