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

    public partial class Form1 : Form
    {
        public string updatedinfopublic { get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || updatedinfo.Text == String.Empty || date.Text == String.Empty || approved.Text == String.Empty || addinfo.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more fields are empty, please fill them up and try again!");
                return;
            }
            else
            {
                
                var text = @"
[table=""width: 500, class: grid, align: center""]
[tr]
    [td][SIZE=1][COLOR=""#FFFFFF""][FONT=Century Gothic][B][COLOR=""#2B60DE""]LSPD[/COLOR] |[/B] Personnel Profile Update[/FONT][/COLOR][/SIZE]
[table=""width: 500, align: center""]
[tr]
    [td][RIGHT][img]https://i.imgur.com/AVSucUE.png[/img][/RIGHT][/td]
    [td]


[LEFT][SIZE=5][COLOR=""#FFFFFF""][FONT=Century Gothic]LOS SANTOS[/FONT][/COLOR]
[COLOR=""#2B60DE""][b]POLICE DEPARTMENT[/b][/COLOR][/SIZE]
[SIZE=1][FONT=Century Gothic][COLOR=""#FFFFFF""][I]Integrity, Courage, & Honor[/I][/COLOR][/FONT][/SIZE][/LEFT][/td]
[/tr]
[/table]

[table=""width: 490, align: center""]
[tr]
    [td][COLOR=#2B60DE][B]Name[/B]:[/COLOR] [COLOR=#D3D3D3]"+name.Text+@"[/COLOR]

[COLOR=#2B60DE][B]Updated Information[/B]:[/COLOR] [COLOR=#D3D3D3]"+updatedinfo.Text+@"[/COLOR]

[COLOR=#2B60DE][B]Date Updated[/B]:[/COLOR] [COLOR=#D3D3D3]"+date.Text+ @"[/COLOR]

[COLOR=#2B60DE][B]Approved By[/B]:[/COLOR] [COLOR=#D3D3D3]"+ approved.Text +@"[/COLOR]

[COLOR=#2B60DE][B]Additional Details[/B]:[/COLOR] [COLOR=#D3D3D3]"+addinfo.Text+ @"[/COLOR][/td]
[/tr]
[/table]
[RIGHT][SIZE=2][/SIZE][COLOR=#D3D3D3][FONT=century gothic][SIZE=1][COLOR=#ffffff]Chief of Police Jaz Bishop
[FONT=century gothic][SIZE=1][COLOR=#ffffff]64th Administration
16/07/2022[/COLOR][/SIZE][/FONT][/COLOR][/SIZE][/FONT][/COLOR][/RIGHT]
[/td]
[/tr]
[/table]
";
                Clipboard.SetText(text.ToString());
                MessageBox.Show("Template has been successfully copied to your clipboard!");
            }
        }
    }
}
