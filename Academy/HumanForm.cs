using DBtools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Academy
{
	public partial class HumanForm : Form
	{
		 internal Models.Human human;
		public HumanForm()
		{
			InitializeComponent();
			
		}
		protected virtual void Compress()
		{
			//упаковывает пользовательские данные из формы в объект класса "Human":
			human = new Models.Human
				(
					Convert.ToInt32(labelID.Text == "" ? " 0" : labelID.Text.Split(':').Last()),
					tbLastName.Text,
					tbFirstName.Text,
					tbMiddleName.Text,
					dtpBirthDate.Value.ToString("yyyy-MM-dd"),
					tbemail.Text,
					tbPhone.Text,
					pictureBoxPhoto.Image
				);

		}

		protected virtual void buttonOK_Click(object sender, EventArgs e)
		{
			Compress();
		}

		private void pictureBoxPhoto_MouseHover(object sender, EventArgs e)
		{
			ToolTip tt = new ToolTip();
			tt.SetToolTip(pictureBoxPhoto, "Сделайте двойной щелчек мышью");// Подсказка при наводке мышью на pictureBox
		}

		private void pictureBoxPhoto_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if(dialog.ShowDialog() == DialogResult.OK)
				pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
			
		}
	}
}
