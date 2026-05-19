using System.Windows.Forms;
using System.Configuration;
using DBtools;

namespace Academy
{
	public partial class MainForm : Form
	{
		Connector connector;
		public MainForm()
		{
			InitializeComponent();
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			dgvStudents.DataSource = connector.Load
				(
				"stud_id, last_name,first_name,middle_name,birth_date, group_name,direction_name",
				"Students, Groups, Directions",
				"[group] = group_id AND direction = direction_id"

				);
			//	dgvStudents.DataSource = connector.Load("SELECT * FROM Students");
			toolStripStatusLabel.Text = $"Кол-во записей: {dgvStudents.RowCount - 1}";

		}

	}
}