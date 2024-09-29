namespace WinFormsApp1
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
            lblKg = new Label();
            txtHeight = new TextBox();
            lblHeight = new Label();
            button1 = new Button();
            txtKg = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblKg.Location = new Point(310, 66);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(170, 38);
            lblKg.TabIndex = 1;
            lblKg.Text = "Килограми";
            lblKg.Click += label1_Click;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtHeight.Location = new Point(216, 220);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(336, 43);
            txtHeight.TabIndex = 2;
            txtHeight.TextChanged += textBox1_TextChanged;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeight.Location = new Point(310, 179);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(150, 38);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Височина";
            lblHeight.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(216, 313);
            button1.Name = "button1";
            button1.Size = new Size(336, 46);
            button1.TabIndex = 5;
            button1.Text = "Изчисли";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtKg
            // 
            txtKg.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtKg.Location = new Point(216, 124);
            txtKg.Name = "txtKg";
            txtKg.Size = new Size(336, 43);
            txtKg.TabIndex = 6;
            txtKg.TextChanged += txtKg_TextChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(153, 388);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 38);
            lblResult.TabIndex = 7;
            lblResult.Click += label1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 450);
            Controls.Add(lblResult);
            Controls.Add(txtKg);
            Controls.Add(button1);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(lblKg);
            Name = "Form1";
            Text = "Височина";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblKg;
        private TextBox txtHeight;
        private Label lblHeight;
        private Button button1;
        private TextBox txtKg;
        private Label lblResult;
    }
}