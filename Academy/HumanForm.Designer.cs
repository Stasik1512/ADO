namespace Academy
{
	partial class HumanForm
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
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.Label();
			this.Phone = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.tbMiddleName = new System.Windows.Forms.TextBox();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.tbemail = new System.Windows.Forms.TextBox();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
			this.labelID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLastName.Location = new System.Drawing.Point(65, 14);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(96, 24);
			this.labelLastName.TabIndex = 0;
			this.labelLastName.Text = "Фамилия:";
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFirstName.Location = new System.Drawing.Point(110, 54);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(51, 24);
			this.labelFirstName.TabIndex = 1;
			this.labelFirstName.Text = "Имя:";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMiddleName.Location = new System.Drawing.Point(58, 94);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(103, 24);
			this.labelMiddleName.TabIndex = 2;
			this.labelMiddleName.Text = "Отчество:";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBirthDate.Location = new System.Drawing.Point(6, 134);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(155, 24);
			this.labelBirthDate.TabIndex = 3;
			this.labelBirthDate.Text = "Дата рождения:";
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.email.Location = new System.Drawing.Point(106, 174);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(55, 24);
			this.email.TabIndex = 4;
			this.email.Text = "email";
			// 
			// Phone
			// 
			this.Phone.AutoSize = true;
			this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Phone.Location = new System.Drawing.Point(66, 214);
			this.Phone.Name = "Phone";
			this.Phone.Size = new System.Drawing.Size(95, 24);
			this.Phone.TabIndex = 5;
			this.Phone.Text = "Телефон:";
			// 
			// tbLastName
			// 
			this.tbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
			this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLastName.Location = new System.Drawing.Point(173, 12);
			this.tbLastName.MaxLength = 50;
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(313, 29);
			this.tbLastName.TabIndex = 6;
			// 
			// tbMiddleName
			// 
			this.tbMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
			this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbMiddleName.Location = new System.Drawing.Point(173, 92);
			this.tbMiddleName.MaxLength = 50;
			this.tbMiddleName.Name = "tbMiddleName";
			this.tbMiddleName.Size = new System.Drawing.Size(313, 29);
			this.tbMiddleName.TabIndex = 7;
			// 
			// tbFirstName
			// 
			this.tbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
			this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbFirstName.Location = new System.Drawing.Point(173, 52);
			this.tbFirstName.MaxLength = 50;
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(313, 29);
			this.tbFirstName.TabIndex = 7;
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpBirthDate.CustomFormat = "yyyy.MMMM.dd";
			this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBirthDate.Location = new System.Drawing.Point(173, 132);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(313, 29);
			this.dtpBirthDate.TabIndex = 8;
			// 
			// tbemail
			// 
			this.tbemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
			this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbemail.Location = new System.Drawing.Point(173, 172);
			this.tbemail.MaxLength = 50;
			this.tbemail.Name = "tbemail";
			this.tbemail.Size = new System.Drawing.Size(313, 29);
			this.tbemail.TabIndex = 9;
			// 
			// tbPhone
			// 
			this.tbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
			this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPhone.Location = new System.Drawing.Point(173, 212);
			this.tbPhone.MaxLength = 16;
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(313, 29);
			this.tbPhone.TabIndex = 10;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOK.Location = new System.Drawing.Point(515, 301);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(87, 34);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCancel.Location = new System.Drawing.Point(608, 301);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(99, 34);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxPhoto.Location = new System.Drawing.Point(501, 12);
			this.pictureBoxPhoto.Name = "pictureBoxPhoto";
			this.pictureBoxPhoto.Size = new System.Drawing.Size(206, 229);
			this.pictureBoxPhoto.TabIndex = 13;
			this.pictureBoxPhoto.TabStop = false;
			this.pictureBoxPhoto.MouseHover += new System.EventHandler(this.pictureBoxPhoto_MouseHover);
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelID.Location = new System.Drawing.Point(10, 321);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(0, 24);
			this.labelID.TabIndex = 14;
			// 
			// HumanForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 347);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.pictureBoxPhoto);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.tbemail);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.tbMiddleName);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.Phone);
			this.Controls.Add(this.email);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.labelLastName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HumanForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "HumanForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.Label email;
		private System.Windows.Forms.Label Phone;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbMiddleName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.TextBox tbemail;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelID;
		protected System.Windows.Forms.PictureBox pictureBoxPhoto;
	}
}