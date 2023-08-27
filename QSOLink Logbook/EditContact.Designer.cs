namespace QSOLink_Logbook
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
            this.RemoveCurrentContact = new System.Windows.Forms.Button();
            this.RSTRcvd = new System.Windows.Forms.TextBox();
            this.RSTSent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // IsDX
            // 
            this.IsDX.AutoSize = true;
            this.IsDX.Location = new System.Drawing.Point(245, 107);
            this.IsDX.Name = "IsDX";
            this.IsDX.Size = new System.Drawing.Size(58, 17);
            this.IsDX.TabIndex = 1;
            this.IsDX.Text = "Is DX?";
            this.IsDX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Contact";
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
            this.Country_Textfield.Location = new System.Drawing.Point(85, 107);
            this.Country_Textfield.Name = "Country_Textfield";
            this.Country_Textfield.Size = new System.Drawing.Size(131, 20);
            this.Country_Textfield.TabIndex = 4;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(22, 110);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 5;
            this.CountryLabel.Text = "Country";
            // 
            // CallSignLabel
            // 
            this.CallSignLabel.AutoSize = true;
            this.CallSignLabel.Location = new System.Drawing.Point(22, 84);
            this.CallSignLabel.Name = "CallSignLabel";
            this.CallSignLabel.Size = new System.Drawing.Size(45, 13);
            this.CallSignLabel.TabIndex = 7;
            this.CallSignLabel.Text = "CallSign";
            // 
            // CallSign_Textfield
            // 
            this.CallSign_Textfield.Location = new System.Drawing.Point(85, 81);
            this.CallSign_Textfield.Name = "CallSign_Textfield";
            this.CallSign_Textfield.Size = new System.Drawing.Size(131, 20);
            this.CallSign_Textfield.TabIndex = 6;
            this.CallSign_Textfield.TextChanged += new System.EventHandler(this.CallSign_Textfield_TextChanged);
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
            this.Mode_ComboBox.Location = new System.Drawing.Point(85, 134);
            this.Mode_ComboBox.Name = "Mode_ComboBox";
            this.Mode_ComboBox.Size = new System.Drawing.Size(131, 21);
            this.Mode_ComboBox.TabIndex = 8;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(22, 137);
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
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.RSTRcvd.Location = new System.Drawing.Point(85, 204);
            this.RSTRcvd.Name = "RSTRcvd";
            this.RSTRcvd.Size = new System.Drawing.Size(31, 20);
            this.RSTRcvd.TabIndex = 18;
            // 
            // RSTSent
            // 
            this.RSTSent.Location = new System.Drawing.Point(85, 175);
            this.RSTSent.Name = "RSTSent";
            this.RSTSent.Size = new System.Drawing.Size(31, 20);
            this.RSTSent.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "RST rcvd";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "RST sent";
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 279);
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
            this.Controls.Add(this.IsDX);
            this.Controls.Add(this.label1);
            this.Name = "EditContact";
            this.Text = "Edit contact";
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
        private System.Windows.Forms.Button RemoveCurrentContact;
        private System.Windows.Forms.TextBox RSTRcvd;
        private System.Windows.Forms.TextBox RSTSent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}