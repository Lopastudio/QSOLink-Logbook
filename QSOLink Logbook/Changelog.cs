using System;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public partial class Changelog : Form
    {
        public Changelog()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Lopastudio/QSOLink-Logbook/");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Lopastudio/QSOLink-Logbook/releases");
        }
    }
}
