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
	public partial class TeacherForm : HumanForm
	{
		Models.Teacher teacher;

		public TeacherForm()
		{
			InitializeComponent();
			dtpWorkSinсe.Value = DateTime.Now;
		}

		protected override void buttonOK_Click(object sender, EventArgs e)
		{
			base.buttonOK_Click(sender, e);
			teacher = new Models.Teacher(human, dtpWorkSinсe.Value);
			DataBase.connector.Insert($"INSERT Teachers({teacher.GetNames()}) VALUES({teacher.GetValues()})");
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}