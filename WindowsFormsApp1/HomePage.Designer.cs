namespace WindowsFormsApp1
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateRegular = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.publicName = new System.Windows.Forms.Label();
            this.addVisitorButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RecentlyVisitedButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.SearchVisitorButton = new System.Windows.Forms.Button();
            this.listVisitorWeeklyButton = new System.Windows.Forms.Button();
            this.listVisitorTodayButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.DateRegular);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 71);
            this.panel1.TabIndex = 0;
            // 
            // DateRegular
            // 
            this.DateRegular.AutoSize = true;
            this.DateRegular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateRegular.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRegular.Location = new System.Drawing.Point(964, 21);
            this.DateRegular.Name = "DateRegular";
            this.DateRegular.Size = new System.Drawing.Size(139, 27);
            this.DateRegular.TabIndex = 2;
            this.DateRegular.Text = "Date and Time";
            this.DateRegular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1302, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(117)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.publicName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1474, 224);
            this.panel2.TabIndex = 1;
            // 
            // publicName
            // 
            this.publicName.AutoSize = true;
            this.publicName.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.publicName.Location = new System.Drawing.Point(577, 85);
            this.publicName.Name = "publicName";
            this.publicName.Size = new System.Drawing.Size(451, 55);
            this.publicName.TabIndex = 1;
            this.publicName.Text = "Samrat public Museum";
            this.publicName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addVisitorButton
            // 
            this.addVisitorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.addVisitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addVisitorButton.Font = new System.Drawing.Font("Myriad Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVisitorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(117)))), ((int)(((byte)(232)))));
            this.addVisitorButton.Location = new System.Drawing.Point(157, 42);
            this.addVisitorButton.Name = "addVisitorButton";
            this.addVisitorButton.Size = new System.Drawing.Size(254, 126);
            this.addVisitorButton.TabIndex = 2;
            this.addVisitorButton.Text = "Add Visitor";
            this.addVisitorButton.UseVisualStyleBackColor = false;
            this.addVisitorButton.Click += new System.EventHandler(this.addVisitorButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.RecentlyVisitedButton);
            this.panel3.Controls.Add(this.settingButton);
            this.panel3.Controls.Add(this.SearchVisitorButton);
            this.panel3.Controls.Add(this.listVisitorWeeklyButton);
            this.panel3.Controls.Add(this.listVisitorTodayButton);
            this.panel3.Controls.Add(this.addVisitorButton);
            this.panel3.Location = new System.Drawing.Point(4, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1470, 440);
            this.panel3.TabIndex = 2;
            // 
            // RecentlyVisitedButton
            // 
            this.RecentlyVisitedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.RecentlyVisitedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecentlyVisitedButton.Font = new System.Drawing.Font("Myriad Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentlyVisitedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(117)))), ((int)(((byte)(232)))));
            this.RecentlyVisitedButton.Location = new System.Drawing.Point(592, 42);
            this.RecentlyVisitedButton.Name = "RecentlyVisitedButton";
            this.RecentlyVisitedButton.Size = new System.Drawing.Size(254, 126);
            this.RecentlyVisitedButton.TabIndex = 7;
            this.RecentlyVisitedButton.Text = "Recently Visited";
            this.RecentlyVisitedButton.UseVisualStyleBackColor = false;
            this.RecentlyVisitedButton.Click += new System.EventHandler(this.RecentlyVisitedButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingButton.Font = new System.Drawing.Font("Myriad Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(117)))), ((int)(((byte)(232)))));
            this.settingButton.Location = new System.Drawing.Point(1007, 210);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(254, 126);
            this.settingButton.TabIndex = 6;
            this.settingButton.Text = "Setting";
            this.settingButton.UseVisualStyleBackColor = false;
            // 
            // SearchVisitorButton
            // 
            this.SearchVisitorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SearchVisitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchVisitorButton.Font = new System.Drawing.Font("Myriad Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchVisitorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(117)))), ((int)(((byte)(232)))));
            this.SearchVisitorButton.Location = new System.Drawing.Point(592, 210);
            this.SearchVisitorButton.Name = "SearchVisitorButton";
            this.SearchVisitorButton.Size = new System.Drawing.Size(254, 126);
            this.SearchVisitorButton.TabIndex = 5;
            this.SearchVisitorButton.Text = "Already Member ? ";
            this.SearchVisitorButton.UseVisualStyleBackColor = false;
            this.SearchVisitorButton.Click += new System.EventHandler(this.SearchVisitorButton_Click);
            // 
            // listVisitorWeeklyButton
            // 
            this.listVisitorWeeklyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listVisitorWeeklyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listVisitorWeeklyButton.Font = new System.Drawing.Font("Myriad Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVisitorWeeklyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(117)))), ((int)(((byte)(232)))));
            this.listVisitorWeeklyButton.Location = new System.Drawing.Point(157, 210);
            this.listVisitorWeeklyButton.Name = "listVisitorWeeklyButton";
            this.listVisitorWeeklyButton.Size = new System.Drawing.Size(254, 126);
            this.listVisitorWeeklyButton.TabIndex = 4;
            this.listVisitorWeeklyButton.Text = "List Visitor Weekly";
            this.listVisitorWeeklyButton.UseVisualStyleBackColor = false;
            this.listVisitorWeeklyButton.Click += new System.EventHandler(this.listVisitorWeeklyButton_Click);
            // 
            // listVisitorTodayButton
            // 
            this.listVisitorTodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listVisitorTodayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listVisitorTodayButton.Font = new System.Drawing.Font("Myriad Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVisitorTodayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(117)))), ((int)(((byte)(232)))));
            this.listVisitorTodayButton.Location = new System.Drawing.Point(1007, 32);
            this.listVisitorTodayButton.Name = "listVisitorTodayButton";
            this.listVisitorTodayButton.Size = new System.Drawing.Size(254, 126);
            this.listVisitorTodayButton.TabIndex = 3;
            this.listVisitorTodayButton.Text = "List Visitor (Today)";
            this.listVisitorTodayButton.UseVisualStyleBackColor = false;
            this.listVisitorTodayButton.Click += new System.EventHandler(this.listVisitorTodayButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(85, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DateRegular;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label publicName;
        private System.Windows.Forms.Button addVisitorButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button listVisitorWeeklyButton;
        private System.Windows.Forms.Button listVisitorTodayButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SearchVisitorButton;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button RecentlyVisitedButton;
    }
}