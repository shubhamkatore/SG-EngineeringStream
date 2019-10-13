using SG.EngineeringStream.PerchedPeacock.DBHelper;
using SG.EngineeringStream.PerchedPeacock.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.Database
{
    public class ParkingData
    {
        public List<Parking> GetParkings(string ConnectionString)
        {
            var ParkingList = new List<Parking>();
            var DataOperation = SQLOperation.ExecuteCommand(ConnectionString, "GetAllParkings");
            foreach (var Data in DataOperation.Rows)
            {
                ParkingList.Add(new Parking((DataRow)Data));
            }
            return ParkingList;
        }
    }
}
