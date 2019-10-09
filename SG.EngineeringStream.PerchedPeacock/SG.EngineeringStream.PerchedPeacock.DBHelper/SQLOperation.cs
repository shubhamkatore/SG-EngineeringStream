﻿using SG.EngineeringStream.PerchedPeacock.DBHelper.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SG.EngineeringStream.PerchedPeacock.DBHelper
{
    public class SQLOperation
    {
        public static DataTable ExecuteCommand(string ConnectionString, string Command, Dictionary<string, string> Parameters = null)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            using (SqlCommand cmd = new SqlCommand(Command, connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (Parameters != null)
                {
                    foreach (var paramval in Parameters)
                    {
                        cmd.Parameters.AddWithValue(paramval.Key, paramval.Value);
                    }
                }
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
