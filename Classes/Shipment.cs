using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Classes
{
    internal abstract class Shipment
    {

        #region Property

        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }

        #endregion

        #region Validation 

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Description cannot be null or empty.");
                }
                else
                {
                    description = value;
                }
            }

        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Weight must be a positive value.");
                }
                else
                {
                    weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Delivery fee must be a positive value.");
                }
                else
                {
                    deliveryFee = value;
                }
            }
        }

        public abstract decimal EstimatedCost { get; }

        #endregion

        #region CTORs

        protected Shipment(string tr)
        {
            trackingCode = tr;
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        protected Shipment(string tr, string desc, decimal wt, decimal fee, DeliveryAddress dest)
        {
            trackingCode = tr;
            Description = desc;
            Weight = wt;
            DeliveryFee = fee;
            Destination = dest;
        }

        #endregion

        #region Methods

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public abstract void PrintShipment();
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }

        public void UpdateWieght(decimal newWeight, decimal extraPackingWeight)
        {
            if (extraPackingWeight > 0)
            {
                Weight = newWeight + extraPackingWeight;
            }
        }

        public abstract Shipment CopyShipment();

        public Shipment ShallowCopy() => (Shipment)this.MemberwiseClone();

        public abstract Shipment DeepCopy();

        #endregion

    }
}
