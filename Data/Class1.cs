namespace Data
{

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class DbConnection
    {
		public string sqlConnectionString
		{
			get
			{
			string dataSource = "BERNADETTE-PC\\LACERTUSDATABASE";
			string initialCatalog = "Apollo";
			string integratedsecurity = "True";
			return ("Data Source=" + dataSource + ";Initial Catalog=" + initialCatalog + ";Integrated Security=" + integratedsecurity); 
			}
		}
    }
}