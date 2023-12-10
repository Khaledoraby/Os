namespace WinFormsApp5
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtage = new TextBox();
            txtname = new TextBox();
            button1 = new Button();
            chklist = new CheckedListBox();
            cmbx = new ComboBox();
            rf = new RadioButton();
            rm = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "your name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 34);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "your age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "your gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 231);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "your course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 162);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "your city";
            // 
            // txtage
            // 
            txtage.Location = new Point(100, 38);
            txtage.Name = "txtage";
            txtage.PlaceholderText = "enter your age";
            txtage.Size = new Size(187, 27);
            txtage.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.Location = new Point(100, 5);
            txtname.Name = "txtname";
            txtname.PlaceholderText = "enter your name ";
            txtname.Size = new Size(187, 27);
            txtname.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(352, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chklist
            // 
            chklist.CheckOnClick = true;
            chklist.FormattingEnabled = true;
            chklist.Items.AddRange(new object[] { "c#", "c++", "c", "python", "php", "java", "java screpit" });
            chklist.Location = new Point(110, 260);
            chklist.Name = "chklist";
            chklist.Size = new Size(150, 114);
            chklist.TabIndex = 10;
            // 
            // cmbx
            // 
            cmbx.FormattingEnabled = true;
            cmbx.Items.AddRange(new object[] { "mit ghamer", "mahalla", "alex", "isamilia", "cairo", "other" });
            cmbx.Location = new Point(100, 159);
            cmbx.Name = "cmbx";
            cmbx.Size = new Size(151, 28);
            cmbx.TabIndex = 11;
            // 
            // rf
            // 
            rf.AutoSize = true;
            rf.Location = new Point(244, 89);
            rf.Name = "rf";
            rf.Size = new Size(76, 24);
            rf.TabIndex = 12;
            rf.TabStop = true;
            rf.Text = "feamle";
            rf.UseVisualStyleBackColor = true;
            // 
            // rm
            // 
            rm.AutoSize = true;
            rm.Location = new Point(110, 87);
            rm.Name = "rm";
            rm.Size = new Size(63, 24);
            rm.TabIndex = 13;
            rm.TabStop = true;
            rm.Text = "male";
            rm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rm);
            Controls.Add(rf);
            Controls.Add(cmbx);
            Controls.Add(chklist);
            Controls.Add(button1);
            Controls.Add(txtname);
            Controls.Add(txtage);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtage;
        private TextBox txtname;
        private Button button1;
        private CheckedListBox chklist;
        private ComboBox cmbx;
        private RadioButton rf;
        private RadioButton rm;
    }
}