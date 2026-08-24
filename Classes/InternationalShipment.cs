using AssignmentOOP05.Inrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Classes
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        #region Prop

        private string destinationCountry;
        private decimal customsFee;

        #endregion

        #region CTORs

        public InternationalShipment(string tr, string desc, decimal wt, decimal fee, DeliveryAddress dest) : base(tr, desc, wt, fee, dest)
        {
        }
        public InternationalShipment(string tr, string desc, decimal wt, decimal fee, DeliveryAddress dest, string destCountry, decimal customFee) : base(tr, desc, wt, fee, dest)
        {
            destinationCountry = destCountry;
            customsFee = customFee;
        }

        #endregion

        #region Validation

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Destination country cannot be null or empty.");
                }
                else
                {
                    destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Customs fee must be a positive value.");
                }
                else
                {
                    customsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (decimal)(Weight * 5) + customsFee; }
        }

        #endregion

        #region Methods

        public override void PrintShipment()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("InternationalShipment");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }

        public virtual string GenerateCustomsReport()
        {
            return $"Customs Report - {TrackingCode}: Destination={DestinationCountry}, CustomsFee={CustomsFee} ";
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        public override Shipment CopyShipment()
        {
            return new InternationalShipment(TrackingCode, Description, Weight, DeliveryFee, Destination, DestinationCountry, CustomsFee);
        }

        #endregion

    }
}
