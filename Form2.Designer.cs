namespace WinFormsApp1
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
            tb1 = new TextBox();
            tb2 = new TextBox();
            lb1 = new Label();
            lb2 = new Label();
            bt1 = new Button();
            bt2 = new Button();
            SuspendLayout();
            // 
            // tb1
            // 
            tb1.Location = new Point(224, 62);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 0;
            // 
            // tb2
            // 
            tb2.Location = new Point(224, 120);
            tb2.Name = "tb2";
            tb2.PasswordChar = '*';
            tb2.Size = new Size(125, 27);
            tb2.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(70, 65);
            lb1.Name = "lb1";
            lb1.Size = new Size(148, 20);
            lb1.TabIndex = 2;
            lb1.Text = "Enter your user name";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(75, 120);
            lb2.Name = "lb2";
            lb2.Size = new Size(143, 20);
            lb2.TabIndex = 3;
            lb2.Text = "Enter your password";
            // 
            // bt1
            // 
            bt1.Location = new Point(466, 241);
            bt1.Name = "bt1";
            bt1.Size = new Size(94, 29);
            bt1.TabIndex = 4;
            bt1.Text = "Login";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(188, 241);
            bt2.Name = "bt2";
            bt2.Size = new Size(94, 29);
            bt2.TabIndex = 5;
            bt2.Text = "Logout";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1;
        private TextBox tb2;
        private Label lb1;
        private Label lb2;
        private Button bt1;
        private Button bt2;
    }
}