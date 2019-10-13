using SG.EngineeringStream.PerchedPeacock.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.Service.Interfaces
{
    public interface IParkingService
    {
        List<Parking> GetParkings(string ConnectionString);
    }
}
