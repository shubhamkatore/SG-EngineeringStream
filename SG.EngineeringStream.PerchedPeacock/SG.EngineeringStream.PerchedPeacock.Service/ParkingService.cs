using SG.EngineeringStream.PerchedPeacock.Database;
using SG.EngineeringStream.PerchedPeacock.Models;
using SG.EngineeringStream.PerchedPeacock.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.Service
{
    public class ParkingService : IParkingService
    {
        ParkingData _parkingData;
        public ParkingService()
        {
            _parkingData = new ParkingData();
        }
        public List<Parking> GetParkings(string ConnectionString)
        {
            return _parkingData.GetParkings(ConnectionString);
        }
    }
}
