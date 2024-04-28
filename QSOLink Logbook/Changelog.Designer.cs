namespace QSOLink_Logbook
{
    partial class Changelog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelog));
            this.Title = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold);
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(776, 49);
            this.Title.TabIndex = 2;
            this.Title.Text = "QSOLink Logbook - ChangeLog";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "v4.0 - Alpha",
            "     - Added DX Cluster (telnet) support",
            "     - UI changes",
            "     - Added changelog",
            "     - Added \"DEV / Debug Menu\"",
            "     - Added locator support",
            "     - Work-In-Progress: Making ADIF work :/ (adif files are not compatible, plea" +
                "ses use the DATA format until next revision, I promise, Ill fix it :))",
            "",
            "v3.4 - Alpha",
            "     - UI Modifications",
            "     - Added Macro Buttons (on screen + F1-F4)",
            "     - Background optimalization + bug fixes",
            "",
            "v3.3 - Alpha",
            "     - Menu bar added",
            "     - \"Load\" function as well as \"Save as\" function were added to support multip" +
                "le logbooks",
            "",
            "v3.2 - Alpha",
            "     - UI redesign",
            "     - Mapping main buttons to function keys (F1-F6)",
            "     - Added \"Help Buttons\"",
            "     - Fixing \"RIG\" information not showing in the settings",
            "",
            "v3.1 - Alpha - Patch1",
            "     - Minor UI patches",
            "     - Added Rig information to the HTML renderer.",
            "",
            "v3.1 - Alpha",
            "     - .ADIF (cabrilo) Support added",
            "",
            "v3.0 - Alpha",
            "     - New icon",
            "     - Modifying UAC Behavour",
            "     - Added \"Auto-Updating\"",
            "     - Switching from \"dotNet 4.7.2\" to \"dotNet 4.8\" Framework",
            "",
            "v2.2 - Alpha",
            "     - Added \"Country lookup\" button to the Add Contact window.",
            "This button automatically fills out the country based on entered callsign.",
            "     - Minor changes to the installer. (Adding startmenu shortcut option).",
            "",
            "v2.1 - Alpha",
            "     - Added \"Settings\"",
            "     - Added \"Callsign display\"",
            "     - Added HTML Exporting",
            "     - Optimalizations",
            "",
            "v1.0 - Alpha",
            "     - Added app logic",
            "     - Modified the application to use Binary insted of Yaml to store data",
            "     - Added \"Add contact\"",
            "     - Added \"Editing contacts\""});
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 368);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Changelog";
            this.Text = "Changelog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox listBox1;
    }
}