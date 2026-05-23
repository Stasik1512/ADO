using DBtools;
using System;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		Connector connector;
		DataGridView[] tables;
		Query[] queries =
		{
			new Query
				(
					"stud_id,FORMATMESSAGE(N'%s %s %s', last_name, first_name,middle_name) AS N'Student',birth_date, group_name,direction_name",
					"Students, Groups, Directions",
					"[group] = group_id AND direction = direction_id"
				),
			new Query
				(
					"group_id, group_name, direction_name, start_date, start_time, learning_days ",
					"Groups,Directions",
					"direction = direction_id"
				),
			new Query("*", "Directions"),
			new Query("*", "Disciplines"),
			new Query("*", "Teachers")

		};
		public MainForm()
		{
			AllocConsole();
			InitializeComponent();
			tables = new DataGridView[] { dgvStudents, dgvGroups,dgvDirections , dgvDisciplines, dgvTeachers };
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			//dgvStudents.DataSource = connector.Load
			//	(
			//	"stud_id, last_name,first_name,middle_name,birth_date, group_name,direction_name",
			//	"Students, Groups, Directions",
			//	"[group] = group_id AND direction = direction_id"

			//	);
			////	dgvStudents.DataSource = connector.Load("SELECT * FROM Students");
			//toolStripStatusLabel.Text = $"Кол-во записей: {dgvStudents.RowCount - 1}";
			tabControl_SelectedIndexChanged(tabControl, null);
			///////////////////////////////////////////////////////////////////////////
			DataTable tGroupsDirection = connector.Load("SELECT * FROM Directions");
			DataRow rowDefault = tGroupsDirection.NewRow();
			rowDefault[0] = 0;
			rowDefault[1] = "Все";
			tGroupsDirection.Rows.InsertAt(rowDefault, 0);
			cbGroupsDirections.DataSource = tGroupsDirection;
			cbGroupsDirections.DisplayMember = "direction_name";
			cbGroupsDirections.ValueMember = "direction_id";
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();

		private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			//tables[i].DataSource = connector.Select("*",$"{tabControl.SelectedTab.Text}");
			tables[i].DataSource = connector.Load
				(
				queries[i].ToString()// + (cbGroupsDirections.SelectedIndex == 0 ? "" : $"AND direction={cbGroupsDirections.SelectedValue}")
				);
			toolStripStatusLabel.Text = $"Cound writing: {tables[i].RowCount - 1}";
			//for(int c = 0;c < tables[i].ColumnCount-1;c++)
			//	tables
			tables[i].Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

		}

		

		private void cbGroupsDirections_SelectionChangeCommitted(object sender, EventArgs e)
		{
			//if (cbGroupsDirections.SelectedIndex >= 0)\
			tables[1].DataSource = connector.Load
				(
				queries[1].ToString() + (cbGroupsDirections.SelectedIndex == 0 ? "" : $" AND direction={cbGroupsDirections.SelectedValue}")
				//$" AND direction={cbGroupsDirections.SelectedValue}"
				); //Обработка для комбобокса SelectionChangeCommitted

			//Console.WriteLine($"SelectedIndex: {cbGroupsDirections.SelectedIndex}");
			//Console.WriteLine($"SelectedIndex: {cbGroupsDirections.SelectedItem}");
			//Console.WriteLine($"SelectedIndex: {cbGroupsDirections.SelectedText}");
			//Console.WriteLine($"SelectedIndex: {cbGroupsDirections.SelectedValue}");  

		}
	}
}