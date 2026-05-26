using DBtools;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academy
{
	public partial class AddStudentForm : Form
	{
		Connector connector;

		public AddStudentForm()
		{
			InitializeComponent();

			connector = new Connector
			(
			 ConfigurationManager
			 .ConnectionStrings["P_421_Import"]
			 .ConnectionString
			);

			LoadGroups();

			AcceptButton = ButtonOk;
			CancelButton = buttonCancel;
		}

		void LoadGroups()
		{
			DataTable table =
			 connector.Load
			 (
			  "SELECT group_id, group_name FROM Groups"
			 );

			cbGroups.DataSource = table;
			cbGroups.DisplayMember = "group_name";
			cbGroups.ValueMember = "group_id";
		}

		private void ButtonOk_Click(object sender, EventArgs e)
		{
			try
			{
				string cmd = $@"INSERT INTO Students
				(
				 last_name,
				 first_name,
				 middle_name,
				 birth_date,
				 [group]
				)
				VALUES
				(
				 N'{tbLastName.Text}',
				 N'{tbFirstName.Text}',
				 N'{tbMiddleName.Text}',
				 '{dtpBirthDate.Value:yyyy-MM-dd}',
				 {cbGroups.SelectedValue}
				)";

				connector.Insert(cmd);

				DialogResult = DialogResult.OK;

				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void buttonOk_Click(object sender, EventArgs e)
		{
			try
			{
				string cmd =$@"INSERT INTO Students
			  (
			   last_name,
			   first_name,
			   middle_name,
			   birth_date,
			   [group]
			  )
			  VALUES
			  (
			   N'{tbLastName.Text}',
			   N'{tbFirstName.Text}',
			   N'{tbMiddleName.Text}',
			   '{dtpBirthDate.Value:yyyy-MM-dd}',
			   {cbGroups.SelectedValue}
			  )";

				connector.Insert(cmd);
				MessageBox.Show("Студент добавлен");
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}