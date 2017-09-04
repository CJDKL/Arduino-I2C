namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.textBox_month = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_partNumber = new System.Windows.Forms.TextBox();
            this.textBox_serialNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(147, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_port
            // 
            this.comboBox_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(17, 14);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 32);
            this.comboBox_port.TabIndex = 1;
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Location = new System.Drawing.Point(17, 60);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(121, 32);
            this.comboBox_baudrate.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(53, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputBox.Location = new System.Drawing.Point(292, 12);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(288, 409);
            this.outputBox.TabIndex = 5;
            // 
            // textBox_day
            // 
            this.textBox_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_day.Location = new System.Drawing.Point(72, 41);
            this.textBox_day.MaxLength = 2;
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.Size = new System.Drawing.Size(38, 29);
            this.textBox_day.TabIndex = 6;
            // 
            // textBox_month
            // 
            this.textBox_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_month.Location = new System.Drawing.Point(117, 41);
            this.textBox_month.MaxLength = 2;
            this.textBox_month.Name = "textBox_month";
            this.textBox_month.Size = new System.Drawing.Size(38, 29);
            this.textBox_month.TabIndex = 7;
            // 
            // textBox_year
            // 
            this.textBox_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_year.Location = new System.Drawing.Point(161, 41);
            this.textBox_year.MaxLength = 4;
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(55, 29);
            this.textBox_year.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox_serialNumber);
            this.panel1.Controls.Add(this.textBox_partNumber);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_day);
            this.panel1.Controls.Add(this.textBox_month);
            this.panel1.Controls.Add(this.textBox_year);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 278);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(74, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "DD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(116, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "MM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(161, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "YYYY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(13, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Serial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(28, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "P/N:";
            // 
            // textBox_partNumber
            // 
            this.textBox_partNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_partNumber.Location = new System.Drawing.Point(72, 85);
            this.textBox_partNumber.MaxLength = 13;
            this.textBox_partNumber.Name = "textBox_partNumber";
            this.textBox_partNumber.Size = new System.Drawing.Size(144, 29);
            this.textBox_partNumber.TabIndex = 15;
            // 
            // textBox_serialNumber
            // 
            this.textBox_serialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_serialNumber.Location = new System.Drawing.Point(72, 127);
            this.textBox_serialNumber.MaxLength = 4;
            this.textBox_serialNumber.Name = "textBox_serialNumber";
            this.textBox_serialNumber.Size = new System.Drawing.Size(144, 29);
            this.textBox_serialNumber.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.comboBox_port);
            this.panel2.Controls.Add(this.comboBox_baudrate);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 114);
            this.panel2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(53, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatAppearance.BorderSize = 10;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(152, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "connection";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox textBox_day;
        private System.Windows.Forms.TextBox textBox_month;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_serialNumber;
        private System.Windows.Forms.TextBox textBox_partNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

