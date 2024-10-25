namespace FirstOopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Car audi = new Car("A3", "Audi");

            Car bmw = new Car("I7", "BMW");

            //Car toyota = new Car("corolla", "");

            audi.Drive();
            bmw.Drive();


            Customer cus1 = new Customer();
            Customer cus2 = new Customer("John", "Doe", 25, 15);
            Customer cus3 = new Customer("Jane", "Fish", 30, 5);

            Console.WriteLine(cus1.FirstName);

            // accessing the read only property
            Console.WriteLine(cus2.Status);
            Console.WriteLine(cus3.Status);


            // setting the details of the customer using the named method parameters
            cus1.SetDetails(lName: "Smith", fName: "James", transac: 50);
            Console.WriteLine(cus1.FirstName);
            Console.WriteLine(cus1.TransactionCount);

            cus2.SetDetails();
            Console.WriteLine(cus2.LastName);

            // using the Custmer static method
            Customer.DoSometing();

            Console.ReadLine();
        }
    }
}
