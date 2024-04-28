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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            this.label1 = new System.Windows.Forms.Label();
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
            this.PowerTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.closeAuto = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.locator = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 20);
            this.dateTimePicker1.TabIndex = 110;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Country_Textfield
            // 
            this.Country_Textfield.Location = new System.Drawing.Point(76, 171);
            this.Country_Textfield.Name = "Country_Textfield";
            this.Country_Textfield.Size = new System.Drawing.Size(200, 20);
            this.Country_Textfield.TabIndex = 8;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(13, 174);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 13);
            this.CountryLabel.TabIndex = 5;
            this.CountryLabel.Text = "Country:";
            this.CountryLabel.Click += new System.EventHandler(this.CountryLabel_Click);
            // 
            // CallSignLabel
            // 
            this.CallSignLabel.AutoSize = true;
            this.CallSignLabel.Location = new System.Drawing.Point(13, 38);
            this.CallSignLabel.Name = "CallSignLabel";
            this.CallSignLabel.Size = new System.Drawing.Size(45, 13);
            this.CallSignLabel.TabIndex = 7;
            this.CallSignLabel.Text = "CallSign";
            // 
            // CallSign_Textfield
            // 
            this.CallSign_Textfield.Location = new System.Drawing.Point(76, 35);
            this.CallSign_Textfield.Name = "CallSign_Textfield";
            this.CallSign_Textfield.Size = new System.Drawing.Size(200, 20);
            this.CallSign_Textfield.TabIndex = 0;
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
            this.Mode_ComboBox.Location = new System.Drawing.Point(76, 118);
            this.Mode_ComboBox.Name = "Mode_ComboBox";
            this.Mode_ComboBox.Size = new System.Drawing.Size(200, 21);
            this.Mode_ComboBox.TabIndex = 4;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(13, 121);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(37, 13);
            this.ModeLabel.TabIndex = 9;
            this.ModeLabel.Text = "Mode:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 300);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 152);
            this.richTextBox1.TabIndex = 100;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Custom comments:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "RST sent:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "RST rcvd:";
            // 
            // RSTSent
            // 
            this.RSTSent.Location = new System.Drawing.Point(74, 61);
            this.RSTSent.Name = "RSTSent";
            this.RSTSent.Size = new System.Drawing.Size(31, 20);
            this.RSTSent.TabIndex = 2;
            // 
            // RSTRcvd
            // 
            this.RSTRcvd.Location = new System.Drawing.Point(74, 90);
            this.RSTRcvd.Name = "RSTRcvd";
            this.RSTRcvd.Size = new System.Drawing.Size(31, 20);
            this.RSTRcvd.TabIndex = 3;
            // 
            // RXFreq
            // 
            this.RXFreq.Location = new System.Drawing.Point(185, 90);
            this.RXFreq.Name = "RXFreq";
            this.RXFreq.Size = new System.Drawing.Size(91, 20);
            this.RXFreq.TabIndex = 7;
            // 
            // TXFreq
            // 
            this.TXFreq.Location = new System.Drawing.Point(185, 61);
            this.TXFreq.Name = "TXFreq";
            this.TXFreq.Size = new System.Drawing.Size(91, 20);
            this.TXFreq.TabIndex = 6;
            this.TXFreq.TextChanged += new System.EventHandler(this.TXFreq_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(111, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "RX Freq (kHz):";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(111, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "TX Freq (kHz):";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lookup Country";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PowerTextbox
            // 
            this.PowerTextbox.Location = new System.Drawing.Point(76, 197);
            this.PowerTextbox.Name = "PowerTextbox";
            this.PowerTextbox.Size = new System.Drawing.Size(68, 20);
            this.PowerTextbox.TabIndex = 5;
            this.PowerTextbox.TextChanged += new System.EventHandler(this.PowerTextbox_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Power (W):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // closeAuto
            // 
            this.closeAuto.AutoSize = true;
            this.closeAuto.Location = new System.Drawing.Point(16, 458);
            this.closeAuto.Name = "closeAuto";
            this.closeAuto.Size = new System.Drawing.Size(220, 17);
            this.closeAuto.TabIndex = 111;
            this.closeAuto.Text = "Automatically close after adding contact?";
            this.closeAuto.UseVisualStyleBackColor = true;
            this.closeAuto.CheckedChanged += new System.EventHandler(this.closeAuto_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(15, 481);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.WaitOnLoad = true;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // locator
            // 
            this.locator.Location = new System.Drawing.Point(76, 145);
            this.locator.Name = "locator";
            this.locator.Size = new System.Drawing.Size(200, 20);
            this.locator.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 14);
            this.label8.TabIndex = 113;
            this.label8.Text = "Locator:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "QSO Date:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 525);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.locator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.closeAuto);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PowerTextbox);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContact";
            this.Text = "Add contact";
            this.Load += new System.EventHandler(this.AddContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox PowerTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox closeAuto;
        private System.Windows.Forms.TextBox locator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}