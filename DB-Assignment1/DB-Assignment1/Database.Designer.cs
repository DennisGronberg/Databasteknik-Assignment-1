namespace DB_Assignment1
{
    partial class Database
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.cmdAddContact = new System.Windows.Forms.Button();
            this.cmdRemoveContact = new System.Windows.Forms.Button();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.splitterVertical = new System.Windows.Forms.GroupBox();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.splitterHorizontal = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSaveChanges = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(927, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(927, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(927, 116);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(182, 20);
            this.txtPhonenumber.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(927, 90);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(182, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(927, 64);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(182, 20);
            this.txtZipcode.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(927, 38);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(182, 20);
            this.txtAdress.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(883, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 13;
            this.cboYear.Location = new System.Drawing.Point(927, 168);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(51, 21);
            this.cboYear.TabIndex = 7;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(984, 168);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(76, 21);
            this.cboMonth.TabIndex = 8;
            // 
            // cboDay
            // 
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Location = new System.Drawing.Point(1066, 168);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(43, 21);
            this.cboDay.TabIndex = 9;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(879, 41);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(42, 13);
            this.lblAdress.TabIndex = 13;
            this.lblAdress.Text = "Adress:";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(872, 67);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(49, 13);
            this.lblZipcode.TabIndex = 14;
            this.lblZipcode.Text = "Zipcode:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(894, 93);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City:";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(845, 119);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(76, 13);
            this.lblPhonenumber.TabIndex = 16;
            this.lblPhonenumber.Text = "Phonenumber:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(883, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(873, 171);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(48, 13);
            this.lblBirthday.TabIndex = 18;
            this.lblBirthday.Text = "Birthday:";
            // 
            // cmdAddContact
            // 
            this.cmdAddContact.Location = new System.Drawing.Point(947, 205);
            this.cmdAddContact.Name = "cmdAddContact";
            this.cmdAddContact.Size = new System.Drawing.Size(78, 31);
            this.cmdAddContact.TabIndex = 10;
            this.cmdAddContact.Text = "Add";
            this.cmdAddContact.UseVisualStyleBackColor = true;
            this.cmdAddContact.Click += new System.EventHandler(this.cmdAddContact_Click);
            // 
            // cmdRemoveContact
            // 
            this.cmdRemoveContact.Location = new System.Drawing.Point(1031, 261);
            this.cmdRemoveContact.Name = "cmdRemoveContact";
            this.cmdRemoveContact.Size = new System.Drawing.Size(78, 31);
            this.cmdRemoveContact.TabIndex = 13;
            this.cmdRemoveContact.Text = "Remove";
            this.cmdRemoveContact.UseVisualStyleBackColor = true;
            this.cmdRemoveContact.Click += new System.EventHandler(this.cmdRemoveContact_Click);
            // 
            // dgContacts
            // 
            this.dgContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Location = new System.Drawing.Point(12, 38);
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.ReadOnly = true;
            this.dgContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContacts.Size = new System.Drawing.Size(807, 558);
            this.dgContacts.TabIndex = 0;
            // 
            // splitterVertical
            // 
            this.splitterVertical.Location = new System.Drawing.Point(834, -10);
            this.splitterVertical.Name = "splitterVertical";
            this.splitterVertical.Size = new System.Drawing.Size(2, 1000);
            this.splitterVertical.TabIndex = 19;
            this.splitterVertical.TabStop = false;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(863, 205);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(78, 31);
            this.cmdUpdate.TabIndex = 12;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(1031, 205);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(78, 31);
            this.cmdClear.TabIndex = 11;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // splitterHorizontal
            // 
            this.splitterHorizontal.Location = new System.Drawing.Point(834, 242);
            this.splitterHorizontal.Name = "splitterHorizontal";
            this.splitterHorizontal.Size = new System.Drawing.Size(300, 2);
            this.splitterHorizontal.TabIndex = 20;
            this.splitterHorizontal.TabStop = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(1031, 205);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(78, 31);
            this.cmdCancel.TabIndex = 21;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSaveChanges
            // 
            this.cmdSaveChanges.Location = new System.Drawing.Point(947, 205);
            this.cmdSaveChanges.Name = "cmdSaveChanges";
            this.cmdSaveChanges.Size = new System.Drawing.Size(78, 31);
            this.cmdSaveChanges.TabIndex = 22;
            this.cmdSaveChanges.Text = "Save";
            this.cmdSaveChanges.UseVisualStyleBackColor = true;
            this.cmdSaveChanges.Visible = false;
            this.cmdSaveChanges.Click += new System.EventHandler(this.cmdSaveChanges_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(62, 12);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(757, 20);
            this.txtSearchBar.TabIndex = 23;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Search:";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 608);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.cmdSaveChanges);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.splitterHorizontal);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.splitterVertical);
            this.Controls.Add(this.dgContacts);
            this.Controls.Add(this.cmdRemoveContact);
            this.Controls.Add(this.cmdAddContact);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblZipcode);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.cboDay);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "Database";
            this.Text = "Database";
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Button cmdAddContact;
        private System.Windows.Forms.Button cmdRemoveContact;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.GroupBox splitterVertical;
        private System.Windows.Forms.GroupBox splitterHorizontal;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSaveChanges;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label lblSearch;
    }
}

