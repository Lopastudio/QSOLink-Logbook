namespace QSOLink_Logbook
{
    partial class AddContact
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
            this.label1 = new System.Windows.Forms.Label();
            this.IsDX = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Country_Textfield = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CallSignLabel = new System.Windows.Forms.Label();
            this.CallSign_Textfield = new System.Windows.Forms.TextBox();
            this.Mode_ComboBox = new System.Windows.Forms.ComboBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RSTSent = new System.Windows.Forms.TextBox();
            this.RSTRcvd = new System.Windows.Forms.TextBox();
            this.RXFreq = new System.Windows.Forms.TextBox();
            this.TXFreq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add your contact";
            // 
            // IsDX
            // 
            this.IsDX.AutoSize = true;
            this.IsDX.Location = new System.Drawing.Point(275, 76);
            this.IsDX.Name = "IsDX";
            this.IsDX.Size = new System.Drawing.Size(58, 17);
            this.IsDX.TabIndex = 1;
            this.IsDX.Text = "Is DX?";
            this.IsDX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Country_Textfield
            // 
            this.Country_Textfield.Location = new System.Drawing.Point(85, 76);
            this.Country_Textfield.Name = "Country_Textfield";
            this.Country_Textfield.Size = new System.Drawing.Size(131, 20);
            this.Country_Textfield.TabIndex = 4;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(22, 79);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 5;
            this.CountryLabel.Text = "Country";
            // 
            // CallSignLabel
            // 
            this.CallSignLabel.AutoSize = true;
            this.CallSignLabel.Location = new System.Drawing.Point(22, 53);
            this.CallSignLabel.Name = "CallSignLabel";
            this.CallSignLabel.Size = new System.Drawing.Size(45, 13);
            this.CallSignLabel.TabIndex = 7;
            this.CallSignLabel.Text = "CallSign";
            // 
            // CallSign_Textfield
            // 
            this.CallSign_Textfield.Location = new System.Drawing.Point(85, 50);
            this.CallSign_Textfield.Name = "CallSign_Textfield";
            this.CallSign_Textfield.Size = new System.Drawing.Size(131, 20);
            this.CallSign_Textfield.TabIndex = 6;
            // 
            // Mode_ComboBox
            // 
            this.Mode_ComboBox.FormattingEnabled = true;
            this.Mode_ComboBox.Items.AddRange(new object[] {
            "AM",
            "FM",
            "USB",
            "LSB",
            "CW",
            "AMTOR",
            "SSTV",
            "FSK",
            "PSK",
            "RTTY",
            "Packet Radio",
            "PACTOR",
            "Olivia",
            "MT63",
            "DominoEX",
            "Contestia",
            "JT65",
            "JT9",
            "FT8",
            "FT4",
            "WSPR",
            "APRS",
            "Hellschreiber",
            "MFSK",
            "ROS",
            "ALE",
            "VARA",
            "ATV",
            "FSTV",
            "Digital ATV",
            "D-Star",
            "System Fusion",
            "DMR",
            "FM Satellites",
            "SSB/CW Satellites",
            "Digital Satellites",
            "EME",
            "Meteor Scatter",
            "QRSS",
            "FreeDV",
            "EchoLink",
            "IRLP",
            "QRP",
            "QRS",
            "QRO",
            "QSK",
            "QSY",
            "QSL",
            "QTH",
            "QRPp"});
            this.Mode_ComboBox.Location = new System.Drawing.Point(85, 103);
            this.Mode_ComboBox.Name = "Mode_ComboBox";
            this.Mode_ComboBox.Size = new System.Drawing.Size(131, 21);
            this.Mode_ComboBox.TabIndex = 8;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(22, 106);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(34, 13);
            this.ModeLabel.TabIndex = 9;
            this.ModeLabel.Text = "Mode";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(266, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(209, 81);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Custom comments";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "RST sent";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "RST rcvd";
            // 
            // RSTSent
            // 
            this.RSTSent.Location = new System.Drawing.Point(83, 142);
            this.RSTSent.Name = "RSTSent";
            this.RSTSent.Size = new System.Drawing.Size(31, 20);
            this.RSTSent.TabIndex = 13;
            // 
            // RSTRcvd
            // 
            this.RSTRcvd.Location = new System.Drawing.Point(83, 171);
            this.RSTRcvd.Name = "RSTRcvd";
            this.RSTRcvd.Size = new System.Drawing.Size(31, 20);
            this.RSTRcvd.TabIndex = 14;
            // 
            // RXFreq
            // 
            this.RXFreq.Location = new System.Drawing.Point(172, 171);
            this.RXFreq.Name = "RXFreq";
            this.RXFreq.Size = new System.Drawing.Size(44, 20);
            this.RXFreq.TabIndex = 18;
            // 
            // TXFreq
            // 
            this.TXFreq.Location = new System.Drawing.Point(172, 142);
            this.TXFreq.Name = "TXFreq";
            this.TXFreq.Size = new System.Drawing.Size(44, 20);
            this.TXFreq.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(120, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "RX Freq";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(120, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "TX Freq";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 21);
            this.button2.TabIndex = 19;
            this.button2.Text = "Lookup Country";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 257);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RXFreq);
            this.Controls.Add(this.TXFreq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RSTRcvd);
            this.Controls.Add(this.RSTSent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.Mode_ComboBox);
            this.Controls.Add(this.CallSignLabel);
            this.Controls.Add(this.CallSign_Textfield);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.Country_Textfield);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IsDX);
            this.Controls.Add(this.label1);
            this.Name = "AddContact";
            this.Text = "Add contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IsDX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Country_Textfield;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label CallSignLabel;
        private System.Windows.Forms.TextBox CallSign_Textfield;
        private System.Windows.Forms.ComboBox Mode_ComboBox;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RSTSent;
        private System.Windows.Forms.TextBox RSTRcvd;
        private System.Windows.Forms.TextBox RXFreq;
        private System.Windows.Forms.TextBox TXFreq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}