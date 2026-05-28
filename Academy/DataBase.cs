using DBtools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Academy
{
	static class DataBase
	{
		public static Connector connector {  get; set; }
		static DataBase()
		{
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
		}
		public static void LoadComboBoxFromBase(ComboBox comboBox, string table, string condition = "")
		{
			string column = table.Substring(0, table.Length - 1).ToLower();
			string cmd = $"SELECT {column}_id,{column}_name FROM {table}";
			if (condition != "") cmd += $" WHERE {condition}";
			DataTable dt = connector.Load(cmd);
			DataRow rowDefault = dt.NewRow();
			rowDefault[0] = 0;
			rowDefault[1] = "Все";
			for (int i = 2; i < dt.Columns.Count; i++) rowDefault[i] = 0;
			dt.Rows.InsertAt(rowDefault, 0);
			comboBox.DataSource = dt;
			comboBox.DisplayMember = $"{column}_name";
			comboBox.ValueMember = $"{column}_id";
		}
	}
}
