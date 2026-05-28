using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBtools;

namespace Academy
{
	static class DataBase
	{
		public static Connector connector {  get; set; }
		static DataBase()
		{
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
		}
	}
}
