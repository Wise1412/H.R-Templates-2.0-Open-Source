using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (update.Text == String.Empty || pplink.Text == String.Empty || msglink.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more field(s) are empty, all fields are required.");
                return;
            }
            else
            {
                var text = @"**Task**: "+update.Text+@"

**Message Link**: "+msglink.Text+@"

**Personnel Profile**: "+pplink.Text+ @"

**Badge Tracker**: https://docs.google.com/spreadsheets/d/1keuCx2liT3fDd-zhHkZc-d0eD7CMHUNB1EkwM4BZk1Q/edit#gid=0

**Department Roster**: https://forums.hzgaming.net/showthread.php/473156-LSPD-Department-Roster-(Make-Edits)
";
                Clipboard.SetText(text);
                MessageBox.Show("Discord Update Template has been copied!");






            }
        }
    }
}
