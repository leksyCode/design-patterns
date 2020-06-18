using System;
using System.Collections.Generic;

namespace ChaneOfResponsibility_State_Observer
{
    

    class Program
    {
        static void Main(string[] args)
        { 
            // Make employees with awaiting state
            var transborderEmployee = new TransborderHandler(new AwaitingPackage());
            var countryEmployee = new CountryHandler(new AwaitingPackage());
            var plovdivEmployee = new PlovdivHandler(new AwaitingPackage());
         
            transborderEmployee.SetNext(countryEmployee).SetNext(plovdivEmployee); // set chain

            Console.WriteLine();

            ClientsSimulation(transborderEmployee);     // Method that simulates clients                   
        }

        public static void ClientsSimulation(AbstractHandler employee)
        {
            List<string> packages = new List<string> { "Plovdiv package", "Transborder package", "Moon package", "Country package" };

            foreach (var package in packages)
            {
                Console.WriteLine($"Client with {package} entered office");

                var result = employee.HandlePackage(package);

                if (result != null) // if employee took the package
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
