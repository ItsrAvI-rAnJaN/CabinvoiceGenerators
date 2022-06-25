using System;
namespace CabInvoiceGenerators
{
    public class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("\t\t\t\t******* WELCOME TO CAB INVOICE GENERATOR PROGRAM *******");

            InvoiceGenerators invoiceGenerator = new InvoiceGenerators(RideTypes.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Total fare : {0}" ,fare);
            Console.ReadKey();

        }
        
    }
}