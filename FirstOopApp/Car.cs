using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOopApp
{
    internal class Car
    {
        // member variables / fields
        private string _model = "";
        private string _brand = "";

        //properties
         //properties allow us to control how our fields are acccess and modified
        public string Model { get => _model; set => _model = value; }
        public string Brand { get => _brand; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered null or empty string");
                    value = "DEFAULTVALUE";
                    _brand = value;
                }
                else
                {
                    _brand = value;
                }
            } }

        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;

            Console.WriteLine($"The car with brand name {Brand} " +
                $"and model {Model} has been created");
        }

        public void Drive()
        {
            Console.WriteLine($"I am a {Brand} and i am driving");
        }
    }
}
