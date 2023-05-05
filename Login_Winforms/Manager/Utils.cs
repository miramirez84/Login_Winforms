using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Winforms.Manager
{
	internal class Utils
	{
		public static DateTime GetServerDate()
		{
			using (SqlConnection conn = new(Properties.Settings.Default.ConnectionString))
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = System.Data.CommandType.Text;
				cmd.CommandText = "Select GetDate();";
				
				conn.Open();
				DateTime ServerDate = (DateTime)cmd.ExecuteScalar();
				return ServerDate;
			}				
		}
		public static string GetClienteAToken()
		{
			return "TOKEN CLIENTE A";
		}
		public static string GetServerName()
		{
			return "SERVER NAME";
		}
	}
}
