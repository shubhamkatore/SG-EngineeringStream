using System;
using System.Collections.Generic;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.Models
{
    public class ParkVehicle : User
    {
       public string VehicleNo { get; set; } 
       public string VehicleWeight { get; set; }
       public string VehicleType { get; set; } 
       public string ParkingLotId { get; set; }
       public string Amount { get; set; }
    }
}
