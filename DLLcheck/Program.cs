using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DBtools;
using System.Net.WebSockets;

namespace DLLcheck
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connection_string = ConfigurationManager .ConnectionStrings["Movies"].ConnectionString;
			Console.WriteLine(connection_string);

			Connector connector = new Connector(connection_string);
			connector.Select("*", "Directors");
			Console.WriteLine("----------------------------------------------------------------");
			connector.Select
				(
				"title, release_date, first_name, last_name",
				"Movies, Directors",
				"director=director_id"
				);
			Console.WriteLine("----------------------------------------------------------------");
			Connector connector_acadamy = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			connector_acadamy.Select("*", "Disciplines");
			Console.WriteLine("----------------------------------------------------------------");
			connector_acadamy.Select("*", "Directions");
		}
	}
}
