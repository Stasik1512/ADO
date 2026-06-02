using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class StudentForm : HumanForm
	{
		Models.Student student;
		public StudentForm()
		{
			InitializeComponent();
			//cbGroups.DataSource = DataBase.connector.Select($"SELECT group_id, group_name FROM Groups");
			//cbGroups.DisplayMember = "group_name";
			//cbGroups.ValueMember = "group_id";
			DataBase.LoadComboBoxFromBase(cbGroups, "Groups"); 
			
		}
		protected override void buttonOK_Click(object sender, EventArgs e)
		{
			base.buttonOK_Click(sender, e);
			student = new Models.Student(human, (int)cbGroups.SelectedValue);
			DataBase.connector.Scalar
				(
					$"INSERT Students({student.GetNames()}) VALUES({student.GetValues()}); SELECT SCOPE_INDENTITY();"
				); 
			if (pictureBoxPhoto.Image != null)
				DataBase.connector.UploadPhoto(student.SerializePhoto(), student.id,"photo", "Students");
			
		}
	}
}