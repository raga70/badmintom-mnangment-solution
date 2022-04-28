namespace WFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTournaments = new System.Windows.Forms.ListBox();
            this.cbSportType = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.cbMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.cbTournamentSystem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbMinPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaxPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTournaments
            // 
            this.lbTournaments.FormattingEnabled = true;
            this.lbTournaments.ItemHeight = 20;
            this.lbTournaments.Location = new System.Drawing.Point(12, 36);
            this.lbTournaments.Name = "lbTournaments";
            this.lbTournaments.Size = new System.Drawing.Size(205, 524);
            this.lbTournaments.TabIndex = 0;
            this.lbTournaments.SelectedIndexChanged += new System.EventHandler(this.lbTournaments_SelectedIndexChanged);
            // 
            // cbSportType
            // 
            this.cbSportType.FormattingEnabled = true;
            this.cbSportType.Location = new System.Drawing.Point(258, 46);
            this.cbSportType.Name = "cbSportType";
            this.cbSportType.Size = new System.Drawing.Size(250, 28);
            this.cbSportType.TabIndex = 2;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(258, 159);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(250, 120);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(258, 316);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 27);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(258, 386);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(250, 27);
            this.dtpEndDate.TabIndex = 5;
            // 
            // cbMinPlayers
            // 
            this.cbMinPlayers.Location = new System.Drawing.Point(625, 46);
            this.cbMinPlayers.Name = "cbMinPlayers";
            this.cbMinPlayers.Size = new System.Drawing.Size(91, 27);
            this.cbMinPlayers.TabIndex = 6;
            // 
            // cbMaxPlayers
            // 
            this.cbMaxPlayers.Location = new System.Drawing.Point(785, 46);
            this.cbMaxPlayers.Name = "cbMaxPlayers";
            this.cbMaxPlayers.Size = new System.Drawing.Size(87, 27);
            this.cbMaxPlayers.TabIndex = 7;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(582, 130);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(308, 104);
            this.rtbAddress.TabIndex = 8;
            this.rtbAddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Event Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Date/Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Date/Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of Players:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "min:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "max:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address:";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(582, 318);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(113, 53);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(777, 318);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(113, 53);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(582, 318);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(113, 53);
            this.btCreate.TabIndex = 19;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // cbTournamentSystem
            // 
            this.cbTournamentSystem.FormattingEnabled = true;
            this.cbTournamentSystem.Location = new System.Drawing.Point(582, 271);
            this.cbTournamentSystem.Name = "cbTournamentSystem";
            this.cbTournamentSystem.Size = new System.Drawing.Size(308, 28);
            this.cbTournamentSystem.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tournament System:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(430, 89);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 24);
            this.rbFemale.TabIndex = 22;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(324, 89);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(63, 24);
            this.rbMale.TabIndex = 23;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Gender:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 624);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTournamentSystem);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.cbMaxPlayers);
            this.Controls.Add(this.cbMinPlayers);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cbSportType);
            this.Controls.Add(this.lbTournaments);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cbMinPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaxPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbTournaments;
        private TextBox tbSearch;
        private ComboBox cbSportType;
        private RichTextBox rtbDescription;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private NumericUpDown cbMinPlayers;
        private NumericUpDown cbMaxPlayers;
        private RichTextBox rtbAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btUpdate;
        private Button btDelete;
        private Button btCreate;
        private ComboBox cbTournamentSystem;
        private Label label9;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label10;
    }
}