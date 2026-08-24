using AssignmentOOP05.Inrefaces;
using AssignmentOOP05.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Classes
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        #region Prop

        private decimal extraFee;

        #endregion

        #region Validation

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Extra fee must be a positive value.");
                }
                else
                {
                    extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (decimal)(Weight * 5) + ExtraFee; }
        }

        #endregion

        #region CTORs

        public ExpressShipment(string tr, string desc, decimal wt, decimal fee, DeliveryAddress dest, decimal extFee) : base(tr, desc, wt, fee, dest)
        {
            extraFee = extFee;
        }

        #endregion

        #region Methods

        public override void PrintShipment()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ExpressShipment");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Extra Fee: {ExtraFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        public override Shipment CopyShipment()
        {
            return new ExpressShipment(TrackingCode, Description, Weight, DeliveryFee, Destination, ExtraFee);
        }


        #endregion
    }
}
