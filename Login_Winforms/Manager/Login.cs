using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Login_Winforms.Manager
{
	internal class Login
	{
		public static Boolean getAccess(String aUsuario, String aPassword)
		{
			using (SqlConnection conn = new(Properties.Settings.Default.ConnectionString))
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "spLogin";
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@usuario", aUsuario);
				cmd.Parameters.AddWithValue("@password", aPassword);

				conn.Open();
				int res = (int)cmd.ExecuteScalar();
				conn.Close();

				if (res == 1) return true;
			}
			return false;
		}

	}
}
