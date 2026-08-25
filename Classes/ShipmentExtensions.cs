using AssignmentOOP05.Inrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Classes
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG | {shipment.GetType().Name}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetType().Name == "Delivered";
        }
    }
}
