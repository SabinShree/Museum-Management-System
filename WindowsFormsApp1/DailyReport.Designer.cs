namespace WindowsFormsApp1
{
    partial class DailyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButtonReport = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVisitorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVisitorInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.totalVisitorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVisitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalVisitorInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalVisitorInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy MMMM dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(65, 89);
            this.dateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(277, 34);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick a date here.";
            // 
            // generateButtonReport
            // 
            this.generateButtonReport.BackColor = System.Drawing.Color.OliveDrab;
            this.generateButtonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButtonReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateButtonReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.generateButtonReport.Location = new System.Drawing.Point(394, 89);
            this.generateButtonReport.Name = "generateButtonReport";
            this.generateButtonReport.Size = new System.Drawing.Size(145, 34);
            this.generateButtonReport.TabIndex = 3;
            this.generateButtonReport.Text = "Generate report";
            this.generateButtonReport.UseVisualStyleBackColor = false;
            this.generateButtonReport.Click += new System.EventHandler(this.generateButtonReport_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            this.chart1.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 198);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total visitor visited";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(527, 480);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.totalVisitorDataGridViewTextBoxColumn,
            this.totalTimesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.totalVisitorInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(553, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 93);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Visitor Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(780, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Individual Visitor data ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn1,
            this.totalVisitorDataGridViewTextBoxColumn1,
            this.totalTimesDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.totalVisitorInfoBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(563, 198);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(616, 480);
            this.dataGridView2.TabIndex = 9;
          //  this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // totalVisitorDataGridViewTextBoxColumn1
            // 
            this.totalVisitorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalVisitorDataGridViewTextBoxColumn1.DataPropertyName = "totalVisitor";
            this.totalVisitorDataGridViewTextBoxColumn1.HeaderText = "Visitor";
            this.totalVisitorDataGridViewTextBoxColumn1.Name = "totalVisitorDataGridViewTextBoxColumn1";
            // 
            // totalTimesDataGridViewTextBoxColumn1
            // 
            this.totalTimesDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalTimesDataGridViewTextBoxColumn1.DataPropertyName = "totalTimes";
            this.totalTimesDataGridViewTextBoxColumn1.HeaderText = "total times (in minutes)";
            this.totalTimesDataGridViewTextBoxColumn1.Name = "totalTimesDataGridViewTextBoxColumn1";
            // 
            // totalVisitorInfoBindingSource1
            // 
            this.totalVisitorInfoBindingSource1.DataSource = typeof(WindowsFormsApp1.TotalVisitorInfo);
            // 
            // totalVisitorInfoBindingSource
            // 
            this.totalVisitorInfoBindingSource.DataSource = typeof(WindowsFormsApp1.TotalVisitorInfo);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // totalVisitorDataGridViewTextBoxColumn
            // 
            this.totalVisitorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalVisitorDataGridViewTextBoxColumn.DataPropertyName = "totalVisitor";
            this.totalVisitorDataGridViewTextBoxColumn.HeaderText = "Total Visitor";
            this.totalVisitorDataGridViewTextBoxColumn.Name = "totalVisitorDataGridViewTextBoxColumn";
            // 
            // totalTimesDataGridViewTextBoxColumn
            // 
            this.totalTimesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalTimesDataGridViewTextBoxColumn.DataPropertyName = "totalTimes";
            this.totalTimesDataGridViewTextBoxColumn.HeaderText = "Times (in minutes)";
            this.totalTimesDataGridViewTextBoxColumn.Name = "totalTimesDataGridViewTextBoxColumn";
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1181, 690);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.generateButtonReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "DailyReport";
            this.Text = "DailyReport";
         //   this.Load += new System.EventHandler(this.DailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalVisitorInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalVisitorInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButtonReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource totalVisitorInfoBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource totalVisitorInfoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVisitorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVisitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimesDataGridViewTextBoxColumn;
    }
}