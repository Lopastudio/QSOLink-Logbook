﻿namespace QSOLink_Logbook
{
    partial class EditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContact));
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
            this.RemoveCurrentContact = new System.Windows.Forms.Button();
            this.RSTRcvd = new System.Windows.Forms.TextBox();
            this.RSTSent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RXFreq = new System.Windows.Forms.TextBox();
            this.TXFreq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PowerTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.locator = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit your existing contact";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply edits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Country_Textfield
            // 
            this.Country_Textfield.Location = new System.Drawing.Point(87, 84);
            this.Country_Textfield.Name = "Country_Textfield";
            this.Country_Textfield.Size = new System.Drawing.Size(131, 20);
            this.Country_Textfield.TabIndex = 4;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(24, 87);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 5;
            this.CountryLabel.Text = "Country";
            // 
            // CallSignLabel
            // 
            this.CallSignLabel.AutoSize = true;
            this.CallSignLabel.Location = new System.Drawing.Point(24, 61);
            this.CallSignLabel.Name = "CallSignLabel";
            this.CallSignLabel.Size = new System.Drawing.Size(45, 13);
            this.CallSignLabel.TabIndex = 7;
            this.CallSignLabel.Text = "CallSign";
            // 
            // CallSign_Textfield
            // 
            this.CallSign_Textfield.Location = new System.Drawing.Point(87, 58);
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
            this.Mode_ComboBox.Location = new System.Drawing.Point(87, 111);
            this.Mode_ComboBox.Name = "Mode_ComboBox";
            this.Mode_ComboBox.Size = new System.Drawing.Size(131, 21);
            this.Mode_ComboBox.TabIndex = 8;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(24, 114);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(34, 13);
            this.ModeLabel.TabIndex = 9;
            this.ModeLabel.Text = "Mode";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(245, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(211, 81);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Custom comments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Editing callsign";
            // 
            // RemoveCurrentContact
            // 
            this.RemoveCurrentContact.Location = new System.Drawing.Point(172, 250);
            this.RemoveCurrentContact.Name = "RemoveCurrentContact";
            this.RemoveCurrentContact.Size = new System.Drawing.Size(149, 23);
            this.RemoveCurrentContact.TabIndex = 13;
            this.RemoveCurrentContact.Text = "Remove this contact";
            this.RemoveCurrentContact.UseVisualStyleBackColor = true;
            this.RemoveCurrentContact.Click += new System.EventHandler(this.RemoveCurrentContact_Click);
            // 
            // RSTRcvd
            // 
            this.RSTRcvd.Location = new System.Drawing.Point(85, 207);
            this.RSTRcvd.Name = "RSTRcvd";
            this.RSTRcvd.Size = new System.Drawing.Size(31, 20);
            this.RSTRcvd.TabIndex = 18;
            // 
            // RSTSent
            // 
            this.RSTSent.Location = new System.Drawing.Point(85, 178);
            this.RSTSent.Name = "RSTSent";
            this.RSTSent.Size = new System.Drawing.Size(31, 20);
            this.RSTSent.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "RST rcvd";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "RST sent";
            // 
            // RXFreq
            // 
            this.RXFreq.Location = new System.Drawing.Point(174, 207);
            this.RXFreq.Name = "RXFreq";
            this.RXFreq.Size = new System.Drawing.Size(44, 20);
            this.RXFreq.TabIndex = 22;
            // 
            // TXFreq
            // 
            this.TXFreq.Location = new System.Drawing.Point(174, 178);
            this.TXFreq.Name = "TXFreq";
            this.TXFreq.Size = new System.Drawing.Size(44, 20);
            this.TXFreq.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(122, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "RX Freq";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(122, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "TX Freq";
            // 
            // PowerTextbox
            // 
            this.PowerTextbox.Location = new System.Drawing.Point(85, 139);
            this.PowerTextbox.Name = "PowerTextbox";
            this.PowerTextbox.Size = new System.Drawing.Size(31, 20);
            this.PowerTextbox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 14);
            this.label8.TabIndex = 23;
            this.label8.Text = "Power (W)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(424, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.WaitOnLoad = true;
            // 
            // locator
            // 
            this.locator.Location = new System.Drawing.Point(294, 107);
            this.locator.Name = "locator";
            this.locator.Size = new System.Drawing.Size(153, 20);
            this.locator.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(243, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 14);
            this.label9.TabIndex = 27;
            this.label9.Text = "Locator";
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 279);
            this.Controls.Add(this.locator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PowerTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RXFreq);
            this.Controls.Add(this.TXFreq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RSTRcvd);
            this.Controls.Add(this.RSTSent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveCurrentContact);
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
            this.Name = "EditContact";
            this.Text = "Edit contact";
            this.Load += new System.EventHandler(this.EditContact_Load);
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
        private System.Windows.Forms.Button RemoveCurrentContact;
        private System.Windows.Forms.TextBox RSTRcvd;
        private System.Windows.Forms.TextBox RSTSent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RXFreq;
        private System.Windows.Forms.TextBox TXFreq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PowerTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox locator;
        private System.Windows.Forms.Label label9;
    }
}