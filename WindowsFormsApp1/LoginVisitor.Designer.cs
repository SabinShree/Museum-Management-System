namespace WindowsFormsApp1
{
    partial class LoginVisitor
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
            this.cardNumberTextField = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cardNumberTextField
            // 
            this.cardNumberTextField.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberTextField.Location = new System.Drawing.Point(192, 145);
            this.cardNumberTextField.Name = "cardNumberTextField";
            this.cardNumberTextField.Size = new System.Drawing.Size(146, 40);
            this.cardNumberTextField.TabIndex = 0;
         //   this.cardNumberTextField.TextChanged += new System.EventHandler(this.cardNumberTextField_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.ForestGreen;
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Add.Location = new System.Drawing.Point(192, 219);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(146, 60);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Visitor Here.";
        //    this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(198, 104);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(128, 17);
            this.cardNumberLabel.TabIndex = 3;
            this.cardNumberLabel.Text = "Enter card Number";
            // 
            // LoginVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(573, 335);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.cardNumberTextField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginVisitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardNumberTextField;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cardNumberLabel;
    }
}