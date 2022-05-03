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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btSaveGame = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPlayer2Score = new System.Windows.Forms.NumericUpDown();
            this.cbPlayer1Score = new System.Windows.Forms.NumericUpDown();
            this.labContestant2 = new System.Windows.Forms.Label();
            this.labContestant1 = new System.Windows.Forms.Label();
            this.lbFight = new System.Windows.Forms.ListBox();
            this.lbRound = new System.Windows.Forms.ListBox();
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
            this.lbTournaments.FormattingEnabled = true;
            this.lbTournaments.ItemHeight = 15;
            this.lbTournaments.Location = new System.Drawing.Point(12, 25);
            this.lbTournaments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTournaments.Name = "lbTournaments";
            this.lbTournaments.Size = new System.Drawing.Size(180, 394);
            this.lbTournaments.TabIndex = 0;
            this.lbTournaments.SelectedIndexChanged += new System.EventHandler(this.lbTournaments_SelectedIndexChanged);
            // 
            // cbSportType
            // 
            this.cbSportType.FormattingEnabled = true;
            this.cbSportType.Location = new System.Drawing.Point(20, 28);
            this.cbSportType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSportType.Name = "cbSportType";
            this.cbSportType.Size = new System.Drawing.Size(219, 23);
            this.cbSportType.TabIndex = 2;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(20, 113);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(219, 91);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(20, 231);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(219, 23);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(20, 284);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(219, 23);
            this.dtpEndDate.TabIndex = 5;
            // 
            // cbMinPlayers
            // 
            this.cbMinPlayers.Location = new System.Drawing.Point(341, 28);
            this.cbMinPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMinPlayers.Name = "cbMinPlayers";
            this.cbMinPlayers.Size = new System.Drawing.Size(80, 23);
            this.cbMinPlayers.TabIndex = 6;
            // 
            // cbMaxPlayers
            // 
            this.cbMaxPlayers.Location = new System.Drawing.Point(481, 28);
            this.cbMaxPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaxPlayers.Name = "cbMaxPlayers";
            this.cbMaxPlayers.Size = new System.Drawing.Size(76, 23);
            this.cbMaxPlayers.TabIndex = 7;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(303, 92);
            this.rtbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(270, 79);
            this.rtbAddress.TabIndex = 8;
            this.rtbAddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Event Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Date/Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Date/Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of Players:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "min:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "max:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address:";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(303, 232);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(99, 40);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(474, 232);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(99, 40);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(303, 232);
            this.btCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(99, 40);
            this.btCreate.TabIndex = 19;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // cbTournamentSystem
            // 
            this.cbTournamentSystem.FormattingEnabled = true;
            this.cbTournamentSystem.Location = new System.Drawing.Point(303, 197);
            this.cbTournamentSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTournamentSystem.Name = "cbTournamentSystem";
            this.cbTournamentSystem.Size = new System.Drawing.Size(270, 23);
            this.cbTournamentSystem.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tournament System:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(170, 61);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 19);
            this.rbFemale.TabIndex = 22;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(78, 61);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 23;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Gender:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(198, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 455);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btSaveGame);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cbPlayer2Score);
            this.tabPage2.Controls.Add(this.cbPlayer1Score);
            this.tabPage2.Controls.Add(this.labContestant2);
            this.tabPage2.Controls.Add(this.labContestant1);
            this.tabPage2.Controls.Add(this.lbFight);
            this.tabPage2.Controls.Add(this.lbRound);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btSaveGame
            // 
            this.btSaveGame.Location = new System.Drawing.Point(502, 338);
            this.btSaveGame.Name = "btSaveGame";
            this.btSaveGame.Size = new System.Drawing.Size(105, 56);
            this.btSaveGame.TabIndex = 8;
            this.btSaveGame.Text = "Save";
            this.btSaveGame.UseVisualStyleBackColor = true;
            this.btSaveGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "pts";
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "pts";
            // 
            // cbPlayer2Score
            // 
            this.cbPlayer2Score.Location = new System.Drawing.Point(455, 140);
            this.cbPlayer2Score.Name = "cbPlayer2Score";
            this.cbPlayer2Score.Size = new System.Drawing.Size(69, 23);
            this.cbPlayer2Score.TabIndex = 5;
            // 
            // cbPlayer1Score
            // 
            this.cbPlayer1Score.Location = new System.Drawing.Point(455, 59);
            this.cbPlayer1Score.Name = "cbPlayer1Score";
            this.cbPlayer1Score.Size = new System.Drawing.Size(69, 23);
            this.cbPlayer1Score.TabIndex = 4;
            // 
            // labContestant2
            // 
            this.labContestant2.AutoSize = true;
            this.labContestant2.Location = new System.Drawing.Point(455, 122);
            this.labContestant2.Name = "labContestant2";
            this.labContestant2.Size = new System.Drawing.Size(72, 15);
            this.labContestant2.TabIndex = 3;
            this.labContestant2.Text = "contestant2:";
            // 
            // labContestant1
            // 
            this.labContestant1.AllowDrop = true;
            this.labContestant1.AutoSize = true;
            this.labContestant1.Location = new System.Drawing.Point(455, 41);
            this.labContestant1.Name = "labContestant1";
            this.labContestant1.Size = new System.Drawing.Size(72, 15);
            this.labContestant1.TabIndex = 2;
            this.labContestant1.Text = "contestant1:";
            // 
            // lbFight
            // 
            this.lbFight.FormattingEnabled = true;
            this.lbFight.ItemHeight = 15;
            this.lbFight.Location = new System.Drawing.Point(96, 6);
            this.lbFight.Name = "lbFight";
            this.lbFight.Size = new System.Drawing.Size(248, 394);
            this.lbFight.TabIndex = 1;
            this.lbFight.SelectedIndexChanged += new System.EventHandler(this.lbFight_SelectedIndexChanged);
            // 
            // lbRound
            // 
            this.lbRound.FormattingEnabled = true;
            this.lbRound.ItemHeight = 15;
            this.lbRound.Location = new System.Drawing.Point(6, 6);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(84, 394);
            this.lbRound.TabIndex = 0;
            this.lbRound.SelectedIndexChanged += new System.EventHandler(this.lbRound_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 468);
            this.Controls.Add(this.lbTournaments);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}