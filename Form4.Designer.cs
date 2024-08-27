namespace WinFormsApp1
{
    partial class Form4
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
            lb1 = new Label();
            tb1 = new TextBox();
            tb2 = new TextBox();
            lb2 = new Label();
            lb3 = new Label();
            tb3 = new TextBox();
            lb4 = new Label();
            cb1 = new ComboBox();
            lb5 = new Label();
            tb5 = new TextBox();
            lb6 = new Label();
            tb6 = new TextBox();
            bt1 = new Button();
            bt2 = new Button();
            lb7 = new Label();
            tb7 = new TextBox();
            lb9 = new Label();
            tb9 = new TextBox();
            lb10 = new Label();
            tb10 = new TextBox();
            lsv1 = new ListView();
            bt3 = new Button();
            bt4 = new Button();
            bt5 = new Button();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(12, 9);
            lb1.Name = "lb1";
            lb1.Size = new Size(24, 20);
            lb1.TabIndex = 2;
            lb1.Text = "ID";
            // 
            // tb1
            // 
            tb1.Location = new Point(42, 9);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 12;
            // 
            // tb2
            // 
            tb2.Location = new Point(67, 49);
            tb2.Name = "tb2";
            tb2.Size = new Size(125, 27);
            tb2.TabIndex = 14;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(12, 49);
            lb2.Name = "lb2";
            lb2.Size = new Size(49, 20);
            lb2.TabIndex = 15;
            lb2.Text = "Name";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Location = new Point(12, 92);
            lb3.Name = "lb3";
            lb3.Size = new Size(50, 20);
            lb3.TabIndex = 16;
            lb3.Text = "Phone";
            // 
            // tb3
            // 
            tb3.Location = new Point(68, 92);
            tb3.Name = "tb3";
            tb3.Size = new Size(125, 27);
            tb3.TabIndex = 17;
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Location = new Point(12, 136);
            lb4.Name = "lb4";
            lb4.Size = new Size(123, 20);
            lb4.TabIndex = 18;
            lb4.Text = "Type of customer";
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Household", "Administrative agency", "Production units", "Business services" });
            cb1.Location = new Point(141, 133);
            cb1.Name = "cb1";
            cb1.Size = new Size(151, 28);
            cb1.TabIndex = 28;
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(12, 180);
            lb5.Name = "lb5";
            lb5.Size = new Size(141, 20);
            lb5.TabIndex = 29;
            lb5.Text = "Number of member";
            // 
            // tb5
            // 
            tb5.Location = new Point(159, 180);
            tb5.Name = "tb5";
            tb5.Size = new Size(125, 27);
            tb5.TabIndex = 30;
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Location = new Point(460, 9);
            lb6.Name = "lb6";
            lb6.Size = new Size(82, 20);
            lb6.TabIndex = 31;
            lb6.Text = "This month";
            // 
            // tb6
            // 
            tb6.Location = new Point(549, 6);
            tb6.Name = "tb6";
            tb6.Size = new Size(125, 27);
            tb6.TabIndex = 32;
            // 
            // bt1
            // 
            bt1.Location = new Point(12, 260);
            bt1.Name = "bt1";
            bt1.Size = new Size(94, 29);
            bt1.TabIndex = 43;
            bt1.Text = "Add";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click_1;
            // 
            // bt2
            // 
            bt2.Location = new Point(159, 260);
            bt2.Name = "bt2";
            bt2.Size = new Size(94, 29);
            bt2.TabIndex = 44;
            bt2.Text = "Edit";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click_1;
            // 
            // lb7
            // 
            lb7.AutoSize = true;
            lb7.Location = new Point(463, 52);
            lb7.Name = "lb7";
            lb7.Size = new Size(82, 20);
            lb7.TabIndex = 46;
            lb7.Text = "Last month";
            // 
            // tb7
            // 
            tb7.Location = new Point(551, 49);
            tb7.Name = "tb7";
            tb7.Size = new Size(125, 27);
            tb7.TabIndex = 47;
            // 
            // lb9
            // 
            lb9.AutoSize = true;
            lb9.Location = new Point(460, 92);
            lb9.Name = "lb9";
            lb9.Size = new Size(42, 20);
            lb9.TabIndex = 50;
            lb9.Text = "Total";
            // 
            // tb9
            // 
            tb9.Location = new Point(551, 85);
            tb9.Name = "tb9";
            tb9.Size = new Size(125, 27);
            tb9.TabIndex = 51;
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new Point(460, 180);
            lb10.Name = "lb10";
            lb10.Size = new Size(85, 20);
            lb10.TabIndex = 54;
            lb10.Text = "Description";
            // 
            // tb10
            // 
            tb10.Location = new Point(549, 180);
            tb10.Multiline = true;
            tb10.Name = "tb10";
            tb10.Size = new Size(239, 74);
            tb10.TabIndex = 55;
            // 
            // lsv1
            // 
            lsv1.FullRowSelect = true;
            lsv1.GridLines = true;
            lsv1.Location = new Point(-1, 308);
            lsv1.Name = "lsv1";
            lsv1.Size = new Size(810, 147);
            lsv1.TabIndex = 56;
            lsv1.UseCompatibleStateImageBehavior = false;
            lsv1.SelectedIndexChanged += lsv1_SelectedIndexChanged_1;
            // 
            // bt3
            // 
            bt3.Location = new Point(332, 260);
            bt3.Name = "bt3";
            bt3.Size = new Size(94, 29);
            bt3.TabIndex = 57;
            bt3.Text = "Delete";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click_1;
            // 
            // bt4
            // 
            bt4.Location = new Point(507, 260);
            bt4.Name = "bt4";
            bt4.Size = new Size(94, 29);
            bt4.TabIndex = 58;
            bt4.Text = "Resest";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click_1;
            // 
            // bt5
            // 
            bt5.Location = new Point(694, 260);
            bt5.Name = "bt5";
            bt5.Size = new Size(94, 29);
            bt5.TabIndex = 59;
            bt5.Text = "Print bill";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click_1;
            bt5.KeyDown += bt5_KeyDown;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(bt3);
            Controls.Add(lsv1);
            Controls.Add(tb10);
            Controls.Add(lb10);
            Controls.Add(tb9);
            Controls.Add(lb9);
            Controls.Add(tb7);
            Controls.Add(lb7);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(tb6);
            Controls.Add(lb6);
            Controls.Add(tb5);
            Controls.Add(lb5);
            Controls.Add(cb1);
            Controls.Add(lb4);
            Controls.Add(tb3);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(lb1);
            Name = "Form4";
            Text = "Form4";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private TextBox tb1;
        private TextBox tb2;
        private Label lb2;
        private Label lb3;
        private TextBox tb3;
        private Label lb4;
        private ComboBox cb1;
        private Label lb5;
        private TextBox tb5;
        private Label lb6;
        private TextBox tb6;
        private Button bt1;
        private Button bt2;
        private Label lb7;
        private TextBox tb7;
        private Label lb9;
        private TextBox tb9;
        private Label lb10;
        private TextBox tb10;
        private ListView lsv1;
        private Button bt3;
        private Button bt4;
        private Button bt5;
    }
}