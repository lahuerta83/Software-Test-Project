namespace ProjectDogGroomer
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
            this.adddog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dogname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nextdog = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adddog
            // 
            this.adddog.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.adddog.Location = new System.Drawing.Point(71, 131);
            this.adddog.Name = "adddog";
            this.adddog.Size = new System.Drawing.Size(365, 26);
            this.adddog.TabIndex = 0;
            this.adddog.Text = "Add Dog Button";
            this.adddog.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.nextdog);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(193, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 333);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // dogname
            // 
            this.dogname.Location = new System.Drawing.Point(174, 53);
            this.dogname.Name = "dogname";
            this.dogname.Size = new System.Drawing.Size(216, 20);
            this.dogname.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 171);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 85);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dog\'s Name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(100, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Nail Trim";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Services";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nextdog
            // 
            this.nextdog.Location = new System.Drawing.Point(68, 275);
            this.nextdog.Name = "nextdog";
            this.nextdog.Size = new System.Drawing.Size(156, 27);
            this.nextdog.TabIndex = 3;
            this.nextdog.Text = "Next Dog";
            this.nextdog.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "fullgroom",
            "partialgroom",
            "Bath",
            "oatmealbath"});
            this.comboBox1.Location = new System.Drawing.Point(57, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "List of Dogs";
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(32, 216);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(117, 290);
            this.line.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(492, 568);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dogname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adddog);
            this.Name = "Form1";
            this.Text = "Leigh Ann\'s Grooming App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adddog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox dogname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button nextdog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox line;
    }
}

