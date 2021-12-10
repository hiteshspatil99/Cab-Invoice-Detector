using System;
using System.Collections.Generic;
using System.Text;

namespace CabServiceInvoice
{
    public class InvoiceGenerator
    {

        public const double COSTPERKILOMETER = 10.0;

        public const double COSTPERMINUTE = 1.0;

        public const double MINIMUMFARE = 5.0;

        public double distance;

        public int time;

        public InvoiceGenerator(double runningDistance, int runningTime)
        {
            this.distance = runningDistance;
            this.time = runningTime;
        }
        public double CalculateCabFare()
        {
            double totalFare = (distance * COSTPERKILOMETER) + (time * COSTPERMINUTE);

            if (totalFare < MINIMUMFARE)
            {
                return MINIMUMFARE;
            }

            return totalFare;
        }
    }
}
