namespace formhafta3V
{
    partial class Form2
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
            b1 = new Button();
            l1 = new Label();
            l2 = new Label();
            l3 = new Label();
            l4 = new Label();
            b2 = new Button();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(12, 12);
            b1.Name = "b1";
            b1.Size = new Size(289, 216);
            b1.TabIndex = 0;
            b1.Text = "ZAR ATMAK İÇİN TIKLAYINIZ.";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            l1.Location = new Point(357, 41);
            l1.Name = "l1";
            l1.Size = new Size(45, 17);
            l1.TabIndex = 1;
            l1.Text = "1.ZAR";
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            l2.Location = new Point(357, 137);
            l2.Name = "l2";
            l2.Size = new Size(47, 17);
            l2.TabIndex = 2;
            l2.Text = "2.ZAR";
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            l3.Location = new Point(341, 78);
            l3.Name = "l3";
            l3.Size = new Size(30, 32);
            l3.TabIndex = 3;
            l3.Text = "=";
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            l4.Location = new Point(341, 171);
            l4.Name = "l4";
            l4.Size = new Size(30, 32);
            l4.TabIndex = 4;
            l4.Text = "=";
            // 
            // b2
            // 
            b2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(424, 12);
            b2.Name = "b2";
            b2.Size = new Size(122, 98);
            b2.TabIndex = 5;
            b2.Text = "BAŞLAMAK İÇİN TIKLAYINIZ.";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b2);
            Controls.Add(l4);
            Controls.Add(l3);
            Controls.Add(l2);
            Controls.Add(l1);
            Controls.Add(b1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private Button b2;
    }
}