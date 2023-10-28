namespace formhafta3V
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
            b1 = new Button();
            l1 = new Label();
            l2 = new Label();
            l3 = new Label();
            l4 = new Label();
            l5 = new Label();
            l6 = new Label();
            pbar1 = new ProgressBar();
            pbar2 = new ProgressBar();
            l7 = new Label();
            l8 = new Label();
            b2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // b1
            // 
            b1.BackColor = Color.Cyan;
            b1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(22, 16);
            b1.Name = "b1";
            b1.Size = new Size(201, 120);
            b1.TabIndex = 0;
            b1.Text = "ZAR ATMAK İÇİN TIKLAYINIZ.";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.BackColor = Color.Yellow;
            l1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            l1.Location = new Point(268, 54);
            l1.Name = "l1";
            l1.Size = new Size(48, 17);
            l1.TabIndex = 1;
            l1.Text = "1. ZAR";
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.BackColor = Color.Red;
            l2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            l2.Location = new Point(379, 54);
            l2.Name = "l2";
            l2.Size = new Size(48, 17);
            l2.TabIndex = 2;
            l2.Text = "2. ZAR";
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            l3.Location = new Point(248, 80);
            l3.Name = "l3";
            l3.Size = new Size(26, 25);
            l3.TabIndex = 3;
            l3.Text = "=";
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            l4.Location = new Point(356, 80);
            l4.Name = "l4";
            l4.Size = new Size(26, 25);
            l4.TabIndex = 4;
            l4.Text = "=";
            // 
            // l5
            // 
            l5.AutoSize = true;
            l5.BackColor = Color.Blue;
            l5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l5.ForeColor = Color.White;
            l5.Location = new Point(22, 173);
            l5.Name = "l5";
            l5.Size = new Size(67, 15);
            l5.TabIndex = 5;
            l5.Text = "OYUNCU 1";
            // 
            // l6
            // 
            l6.AutoSize = true;
            l6.BackColor = Color.Fuchsia;
            l6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l6.ForeColor = Color.White;
            l6.Location = new Point(22, 239);
            l6.Name = "l6";
            l6.Size = new Size(67, 15);
            l6.TabIndex = 6;
            l6.Text = "OYUNCU 2";
            // 
            // pbar1
            // 
            pbar1.Location = new Point(95, 164);
            pbar1.Name = "pbar1";
            pbar1.Size = new Size(413, 36);
            pbar1.TabIndex = 7;
            // 
            // pbar2
            // 
            pbar2.Location = new Point(95, 228);
            pbar2.Name = "pbar2";
            pbar2.Size = new Size(413, 36);
            pbar2.TabIndex = 8;
            // 
            // l7
            // 
            l7.AutoSize = true;
            l7.Location = new Point(514, 173);
            l7.Name = "l7";
            l7.Size = new Size(15, 15);
            l7.TabIndex = 9;
            l7.Text = "=";
            // 
            // l8
            // 
            l8.AutoSize = true;
            l8.Location = new Point(514, 239);
            l8.Name = "l8";
            l8.Size = new Size(15, 15);
            l8.TabIndex = 10;
            l8.Text = "=";
            // 
            // b2
            // 
            b2.BackColor = Color.Crimson;
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(449, 39);
            b2.Name = "b2";
            b2.Size = new Size(113, 66);
            b2.TabIndex = 11;
            b2.Text = "OYUNDAN ÇIKMAK İÇİN TIKLAYINIZ.";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(574, 284);
            Controls.Add(label1);
            Controls.Add(b2);
            Controls.Add(l8);
            Controls.Add(l7);
            Controls.Add(pbar2);
            Controls.Add(pbar1);
            Controls.Add(l6);
            Controls.Add(l5);
            Controls.Add(l4);
            Controls.Add(l3);
            Controls.Add(l2);
            Controls.Add(l1);
            Controls.Add(b1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private Label l5;
        private Label l6;
        private ProgressBar pbar1;
        private ProgressBar pbar2;
        private Label l7;
        private Label l8;
        private Button b2;
        private Label label1;
    }
}