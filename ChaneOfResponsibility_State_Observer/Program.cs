using System;
using System.Collections.Generic;

namespace ChaneOfResponsibility_State_Observer
{
    

    class Program
    {
        static void Main(string[] args)
        {
           
            // Make employees with awaiting state 
            var transborderEmployee = new TransborderEmployee(new AwaitingPackage());
            var countryEmployee = new CountryEmployee(new AwaitingPackage());
            var plovdivEmployee = new PlovdivEmployee(new AwaitingPackage());

            var observer = new ObserverEmployee(); // attach observer to employees
            transborderEmployee.Attach(observer);
            countryEmployee.Attach(observer);
            plovdivEmployee.Attach(observer);

            transborderEmployee.SetNext(countryEmployee).SetNext(plovdivEmployee); // set chain

            Console.WriteLine();

            ClientsSimulation(transborderEmployee);     // Method that simulates clients                   
        }

        public static void ClientsSimulation(AbstractEmployee employee)
        {
            List<string> packages = new List<string> { "package for Plovdiv", "package for Transborder", "package for Moon", "package for Country", "package for Plovdiv" };

            foreach (var package in packages)
            {
                Console.WriteLine($"Client with {package} entered office");

                if (!employee.HandlePackage(package))
                {
                    Console.WriteLine($"  {package} was rejected");
                }

            }
        }
    }

}
