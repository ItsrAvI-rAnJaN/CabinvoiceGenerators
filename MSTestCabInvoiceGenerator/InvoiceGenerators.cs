using System;

namespace MSTestCabInvoiceGenerator
{
    internal class InvoiceGenerators
    {
        private RideTypes nORMAL;

        public InvoiceGenerators(RideTypes nORMAL)
        {
            this.nORMAL = nORMAL;
        }

        internal double CalculateFare(double distance, int time)
        {
            throw new NotImplementedException();
        }
    }
}