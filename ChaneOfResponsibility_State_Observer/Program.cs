using System;
using System.Collections.Generic;

namespace ChaneOfResponsibility_State_Observer
{
    class Program
    {
        static void Main(string[] args)
        {           
            var transborderEmployee = new TransborderHandler();
            var countryEmployee = new CountryHandler();
            var plovdivEmployee = new PlovdivHandler();

            // set chain
            transborderEmployee.SetNext(countryEmployee).SetNext(plovdivEmployee);


          
            ClientsSimulation(transborderEmployee);                       
        }

        public static void ClientsSimulation(AbstractHandler handler)
        {
            List<string> packages = new List<string> { "Plovdiv package", "Transborder package", "Moon package", "Country package" };

            foreach (var package in packages)
            {
                Console.WriteLine($"Client with {package} entered office");

                var result = handler.Handle(package);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {package} was rejected.");
                }
            }
        }
    }

}
