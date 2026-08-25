using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Classes
{
    internal class DeliveryAddress
    {

        #region Property

        public string city;
        public string street;
        public int buildingNumber;

        #endregion

        #region CTORs

        public DeliveryAddress(string City, string Street, int BuildingNumber)
        {
            city = City;
            street = Street;
            buildingNumber = BuildingNumber;
        }

        #endregion

        #region Methods

        public string GetFullAddress()
        {
            return $"City:{city},  Street:{street},  BuildingNumber:{buildingNumber} ";
        }

        public DeliveryAddress copy() => new DeliveryAddress(city, street, buildingNumber);
        #endregion

    }
}
