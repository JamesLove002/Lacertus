namespace LacertusStartup
{

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

    public class VerifyLogin
    {
		string sqlConnectionString
		{
			get
			{
				return GetSQLConnectionString();
			}
		}
		public string correctPassword(string usernameInput)
		
		{
				string sql = String.Format(@"SELECT UD_Password FROM [User_Data]
											WHERE UD_Username = {0}", usernameInput);
				if (sql != null)
				{
					using (var sqlConnection = new SqlConnection(sqlConnectionString))
					{
						SqlCommand cmd = new SqlCommand();
						cmd.CommandText = sql;
						return cmd.ExecuteScalar().ToString();
					}
				}
				else
				{
					return "Password Not Found";
				}
		}

		#region
		//get
			//{
			//	using (var SqlConnection = new SqlConnection(sqlConnectionString))
			//	{
			//		SqlCommand cmd = new SqlCommand();
			//		SqlDataReader reader;
			//
			//		cmd.CommandText = "SELECT * FROM User_Data";
			//		cmd.CommandType = CommandType.Text;
			//		cmd.Connection = SqlConnection;
			//		
			//		SqlConnection.Open();
			//		reader = cmd.ExecuteReader();
			//
			//		Object[] values = new Object[reader.FieldCount];
			//		reader.GetValues(values);
			//		string StoredValues = (string)values[0];
			//		
			//		SqlConnection.Close();
			//
			//		return StoredValues;
			//	}
		//}
		#endregion

		public bool LoginFunction(string usernameInput, string PasswordInput)
		{
			if (PasswordInput == correctPassword(usernameInput))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private string GetSQLConnectionString()
		{
			string dataSource = "BERNADETTE-PC\\LACERTUSDATABASE";
			string initialCatalog = "Initial Catalog=Apollo";
			string integratedsecurity = "True";
			return ("Data Source=" + dataSource + ";Initial Catalog=" + initialCatalog + ";Integrated Security=" + integratedsecurity); 
		}
    }
}
//
//#if DEBUG
//
//namespace LacertusStartup.Test
//{
//	 class TestLogin
//	 {
//		 void passwordComparisonComparison()
//		 {
//			string passwordEntry = "test Password";
//			string intentionallyIncorectPassword = "incorrect Password";
//
//		 }
//	 }
//}
//#endif 
