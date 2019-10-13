using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public int AvailableSpace { get; set; }
        public string Location { get; set; }

        public Parking()
        {

        }

        public Parking(DataRow Data)
        {
            Id = Convert.ToInt32(Data["ID"]);
            Capacity = Convert.ToInt32(Data["Capacity"]);
            Name = Data["Name"].ToString();
            AvailableSpace = Convert.ToInt32(Data["AvailableSpace"]);
            Location = Data["Location"].ToString();
        }
    }
}
