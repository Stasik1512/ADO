namespace Academy
{
	partial class StudentForm
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
			this.cbGroups = new System.Windows.Forms.ComboBox();
			this.LabelGroup = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxPhoto
			// 
			// 
			// cbGroups
			// 
			this.cbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbGroups.FormattingEnabled = true;
			this.cbGroups.Location = new System.Drawing.Point(173, 257);
			this.cbGroups.Name = "cbGroups";
			this.cbGroups.Size = new System.Drawing.Size(313, 32);
			this.cbGroups.TabIndex = 14;
			// 
			// LabelGroup
			// 
			this.LabelGroup.AutoSize = true;
			this.LabelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelGroup.Location = new System.Drawing.Point(78, 254);
			this.LabelGroup.Name = "LabelGroup";
			this.LabelGroup.Size = new System.Drawing.Size(83, 24);
			this.LabelGroup.TabIndex = 15;
			this.LabelGroup.Text = "Группа: ";
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 407);
			this.Controls.Add(this.LabelGroup);
			this.Controls.Add(this.cbGroups);
			this.Name = "StudentForm";
			this.Text = "StudentForm";
			this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
			this.Controls.SetChildIndex(this.cbGroups, 0);
			this.Controls.SetChildIndex(this.LabelGroup, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbGroups;
		private System.Windows.Forms.Label LabelGroup;
	}
}