namespace Academy
{
	partial class TeacherForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dtpWorkSinсe = new System.Windows.Forms.DateTimePicker();
			this.labelWorkSinse = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dtpWorkSinсe
			// 
			this.dtpWorkSinсe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpWorkSinсe.Location = new System.Drawing.Point(173, 249);
			this.dtpWorkSinсe.Name = "dtpWorkSinсe";
			this.dtpWorkSinсe.Size = new System.Drawing.Size(313, 29);
			this.dtpWorkSinсe.TabIndex = 15;
			// 
			// labelWorkSinse
			// 
			this.labelWorkSinse.AutoSize = true;
			this.labelWorkSinse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWorkSinse.Location = new System.Drawing.Point(46, 251);
			this.labelWorkSinse.Name = "labelWorkSinse";
			this.labelWorkSinse.Size = new System.Drawing.Size(115, 24);
			this.labelWorkSinse.TabIndex = 16;
			this.labelWorkSinse.Text = "Работает с:";
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 360);
			this.Controls.Add(this.labelWorkSinse);
			this.Controls.Add(this.dtpWorkSinсe);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.Controls.SetChildIndex(this.dtpWorkSinсe, 0);
			this.Controls.SetChildIndex(this.labelWorkSinse, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpWorkSinсe;
		private System.Windows.Forms.Label labelWorkSinse;
	}
}