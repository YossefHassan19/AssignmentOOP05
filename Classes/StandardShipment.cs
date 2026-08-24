using AssignmentOOP05.Inrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Classes
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {

        public StandardShipment(string tr, string desc, decimal wt, decimal fee, DeliveryAddress dest) : base(tr, desc, wt, fee, dest) { }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }


        public override void PrintShipment()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("StandardShipment");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }

        public override Shipment CopyShipment()
        {
            return new StandardShipment(TrackingCode, Description, Weight, DeliveryFee, Destination);
        }

    }
}
