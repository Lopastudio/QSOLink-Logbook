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
            this.RSTSent.TextChanged += new System.EventHandler(this.RSTSent_TextChanged);
            // 
            // RSTRcvd
            // 
            this.RSTRcvd.Location = new System.Drawing.Point(83, 171);
            this.RSTRcvd.Name = "RSTRcvd";
            this.RSTRcvd.Size = new System.Drawing.Size(31, 20);
            this.RSTRcvd.TabIndex = 14;
            this.RSTRcvd.TextChanged += new System.EventHandler(this.RSTRcvd_TextChanged);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 257);
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
            this.Load += new System.EventHandler(this.AddContact_Load);
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
    }
}