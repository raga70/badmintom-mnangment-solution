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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btSaveGame = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPlayer2Score = new System.Windows.Forms.NumericUpDown();
            this.cbPlayer1Score = new System.Windows.Forms.NumericUpDown();
            this.labContestant2 = new System.Windows.Forms.Label();
            this.labContestant1 = new System.Windows.Forms.Label();
            this.lbFight = new System.Windows.Forms.ListBox();
            this.lbRound = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbMinPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaxPlayers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlayer2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlayer1Score)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTournaments
            // 
            this.lbTournaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTournaments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.lbTournaments.FormattingEnabled = true;
            this.lbTournaments.ItemHeight = 18;
            this.lbTournaments.Location = new System.Drawing.Point(14, 111);
            this.lbTournaments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbTournaments.Name = "lbTournaments";
            this.lbTournaments.Size = new System.Drawing.Size(213, 436);
            this.lbTournaments.TabIndex = 0;
            this.lbTournaments.SelectedIndexChanged += new System.EventHandler(this.lbTournaments_SelectedIndexChanged);
            // 
            // cbSportType
            // 
            this.cbSportType.BackColor = System.Drawing.Color.White;
            this.cbSportType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.cbSportType.FormattingEnabled = true;
            this.cbSportType.Location = new System.Drawing.Point(26, 33);
            this.cbSportType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSportType.Name = "cbSportType";
            this.cbSportType.Size = new System.Drawing.Size(281, 26);
            this.cbSportType.TabIndex = 2;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.rtbDescription.Location = new System.Drawing.Point(26, 136);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(281, 108);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.dtpStartDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.dtpStartDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.dtpStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(26, 277);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(281, 24);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(26, 341);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(281, 24);
            this.dtpEndDate.TabIndex = 5;
            // 
            // cbMinPlayers
            // 
            this.cbMinPlayers.BackColor = System.Drawing.Color.White;
            this.cbMinPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbMinPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbMinPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.cbMinPlayers.Location = new System.Drawing.Point(429, 37);
            this.cbMinPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMinPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cbMinPlayers.Name = "cbMinPlayers";
            this.cbMinPlayers.Size = new System.Drawing.Size(103, 20);
            this.cbMinPlayers.TabIndex = 6;
            this.cbMinPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cbMaxPlayers
            // 
            this.cbMaxPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbMaxPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbMaxPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.cbMaxPlayers.Location = new System.Drawing.Point(610, 39);
            this.cbMaxPlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMaxPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cbMaxPlayers.Name = "cbMaxPlayers";
            this.cbMaxPlayers.Size = new System.Drawing.Size(98, 20);
            this.cbMaxPlayers.TabIndex = 7;
            this.cbMaxPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rtbAddress
            // 
            this.rtbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.rtbAddress.Location = new System.Drawing.Point(389, 111);
            this.rtbAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(346, 94);
            this.rtbAddress.TabIndex = 8;
            this.rtbAddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Event Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Date/Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Date/Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of Players:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.label6.Location = new System.Drawing.Point(394, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "min:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.label7.Location = new System.Drawing.Point(569, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "max:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address:";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(389, 278);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(127, 48);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(610, 278);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(127, 48);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.btCreate.FlatAppearance.BorderSize = 0;
            this.btCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreate.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCreate.ForeColor = System.Drawing.Color.White;
            this.btCreate.Location = new System.Drawing.Point(389, 278);
            this.btCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(127, 48);
            this.btCreate.TabIndex = 19;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // cbTournamentSystem
            // 
            this.cbTournamentSystem.BackColor = System.Drawing.Color.White;
            this.cbTournamentSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTournamentSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTournamentSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.cbTournamentSystem.FormattingEnabled = true;
            this.cbTournamentSystem.Location = new System.Drawing.Point(389, 237);
            this.cbTournamentSystem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTournamentSystem.Name = "cbTournamentSystem";
            this.cbTournamentSystem.Size = new System.Drawing.Size(280, 26);
            this.cbTournamentSystem.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tournament System:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.rbFemale.Location = new System.Drawing.Point(218, 73);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(84, 22);
            this.rbFemale.TabIndex = 22;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.rbMale.Location = new System.Drawing.Point(100, 73);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(65, 22);
            this.rbMale.TabIndex = 23;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Gender:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(247, -28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 609);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cbSportType);
            this.tabPage1.Controls.Add(this.rbMale);
            this.tabPage1.Controls.Add(this.rtbDescription);
            this.tabPage1.Controls.Add(this.rbFemale);
            this.tabPage1.Controls.Add(this.dtpStartDate);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dtpEndDate);
            this.tabPage1.Controls.Add(this.cbTournamentSystem);
            this.tabPage1.Controls.Add(this.cbMinPlayers);
            this.tabPage1.Controls.Add(this.btCreate);
            this.tabPage1.Controls.Add(this.cbMaxPlayers);
            this.tabPage1.Controls.Add(this.btDelete);
            this.tabPage1.Controls.Add(this.rtbAddress);
            this.tabPage1.Controls.Add(this.btUpdate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(856, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.panel4.Location = new System.Drawing.Point(389, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 2);
            this.panel4.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.panel3.Location = new System.Drawing.Point(26, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 2);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.panel2.Location = new System.Drawing.Point(572, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 2);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.panel1.Location = new System.Drawing.Point(396, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 2);
            this.panel1.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.btSaveGame);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cbPlayer2Score);
            this.tabPage2.Controls.Add(this.cbPlayer1Score);
            this.tabPage2.Controls.Add(this.labContestant2);
            this.tabPage2.Controls.Add(this.labContestant1);
            this.tabPage2.Controls.Add(this.lbFight);
            this.tabPage2.Controls.Add(this.lbRound);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(856, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Play";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.panel6.Location = new System.Drawing.Point(585, 189);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(89, 2);
            this.panel6.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.panel5.Location = new System.Drawing.Point(585, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 2);
            this.panel5.TabIndex = 26;
            // 
            // btSaveGame
            // 
            this.btSaveGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.btSaveGame.FlatAppearance.BorderSize = 0;
            this.btSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveGame.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSaveGame.ForeColor = System.Drawing.Color.White;
            this.btSaveGame.Location = new System.Drawing.Point(653, 416);
            this.btSaveGame.Margin = new System.Windows.Forms.Padding(4);
            this.btSaveGame.Name = "btSaveGame";
            this.btSaveGame.Size = new System.Drawing.Size(128, 58);
            this.btSaveGame.TabIndex = 8;
            this.btSaveGame.Text = "Save";
            this.btSaveGame.UseVisualStyleBackColor = false;
            this.btSaveGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(676, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "pts";
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(676, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "pts";
            // 
            // cbPlayer2Score
            // 
            this.cbPlayer2Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPlayer2Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.cbPlayer2Score.Location = new System.Drawing.Point(585, 168);
            this.cbPlayer2Score.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlayer2Score.Name = "cbPlayer2Score";
            this.cbPlayer2Score.Size = new System.Drawing.Size(89, 20);
            this.cbPlayer2Score.TabIndex = 5;
            // 
            // cbPlayer1Score
            // 
            this.cbPlayer1Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPlayer1Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.cbPlayer1Score.Location = new System.Drawing.Point(585, 71);
            this.cbPlayer1Score.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlayer1Score.Name = "cbPlayer1Score";
            this.cbPlayer1Score.Size = new System.Drawing.Size(89, 20);
            this.cbPlayer1Score.TabIndex = 4;
            // 
            // labContestant2
            // 
            this.labContestant2.AutoSize = true;
            this.labContestant2.Location = new System.Drawing.Point(585, 147);
            this.labContestant2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labContestant2.Name = "labContestant2";
            this.labContestant2.Size = new System.Drawing.Size(89, 18);
            this.labContestant2.TabIndex = 3;
            this.labContestant2.Text = "contestant2:";
            // 
            // labContestant1
            // 
            this.labContestant1.AllowDrop = true;
            this.labContestant1.AutoSize = true;
            this.labContestant1.Location = new System.Drawing.Point(585, 50);
            this.labContestant1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labContestant1.Name = "labContestant1";
            this.labContestant1.Size = new System.Drawing.Size(89, 18);
            this.labContestant1.TabIndex = 2;
            this.labContestant1.Text = "contestant1:";
            // 
            // lbFight
            // 
            this.lbFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.lbFight.FormattingEnabled = true;
            this.lbFight.ItemHeight = 18;
            this.lbFight.Location = new System.Drawing.Point(135, 33);
            this.lbFight.Margin = new System.Windows.Forms.Padding(4);
            this.lbFight.Name = "lbFight";
            this.lbFight.Size = new System.Drawing.Size(318, 472);
            this.lbFight.TabIndex = 1;
            this.lbFight.SelectedIndexChanged += new System.EventHandler(this.lbFight_SelectedIndexChanged);
            // 
            // lbRound
            // 
            this.lbRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.lbRound.FormattingEnabled = true;
            this.lbRound.ItemHeight = 18;
            this.lbRound.Location = new System.Drawing.Point(19, 33);
            this.lbRound.Margin = new System.Windows.Forms.Padding(4);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(107, 472);
            this.lbRound.TabIndex = 0;
            this.lbRound.SelectedIndexChanged += new System.EventHandler(this.lbRound_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Manage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.btPlay.FlatAppearance.BorderSize = 0;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPlay.ForeColor = System.Drawing.Color.White;
            this.btPlay.Location = new System.Drawing.Point(0, 53);
            this.btPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(247, 48);
            this.btPlay.TabIndex = 28;
            this.btPlay.Text = "Play ";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 28;
            this.label13.Text = "Rounds:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(135, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Fights:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1098, 562);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTournaments);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cbMinPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaxPlayers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlayer2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlayer1Score)).EndInit();
            this.ResumeLayout(false);

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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btSaveGame;
        private Label label12;
        private Label label11;
        private NumericUpDown cbPlayer2Score;
        private NumericUpDown cbPlayer1Score;
        private Label labContestant2;
        private Label labContestant1;
        private ListBox lbFight;
        private ListBox lbRound;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
        private Button btPlay;
        private Label label14;
        private Label label13;
    }
}