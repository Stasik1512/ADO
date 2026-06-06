using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
			this.Text = "Добавление нового студента: ";
			//cbGroups.DataSource = DataBase.connector.Select($"SELECT group_id, group_name FROM Groups");
			//cbGroups.DisplayMember = "group_name";
			//cbGroups.ValueMember = "group_id";
			DataBase.LoadComboBoxFromBase(cbGroups, "Groups"); 
			
		}
		public StudentForm(int id) : this() // this - вызывает конструктор по умолчанию
		{
			DataTable data = DataBase.connector.Load("*", "Students", $"stud_id = {id}");
			this.Text = "Редактирование студента: ";
			human = student = new Models.Student(data.Rows[0].ItemArray);
			Exctract();
		}
		protected override void buttonOK_Click(object sender, EventArgs e)
		{
			base.buttonOK_Click(sender, e);
			student = new Models.Student(human, (int)cbGroups.SelectedValue);
			if (student.id == 0) student.id = Convert.ToInt32
				(
					DataBase.connector.Scalar
					(
						$"INSERT Students({student.GetNames()}) VALUES({student.GetValues()}); SELECT SCOPE_IDENTITY();" //возвращает id последней созданной записи
					)
				);
			else DataBase.connector.Update("Students", student.GetUpdateExpression(), $"stud_id= {student.id}");
		
			if (pictureBoxPhoto.Image != null)
				DataBase.connector.UploadPhoto(student.SerializePhoto(), student.id,"photo", "Students");

		}

		protected override void Exctract()
		{
			base.Exctract();
			cbGroups.SelectedValue = student.group;
		}

	}
}