using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Button CurrentBtn;
        private Form activeForm;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnsender)
        {
            Color color = Color.Cyan;
            if (btnsender != null)
            {
                if (CurrentBtn != (Button)btnsender)
                {
                    DisableButton();
                    CurrentBtn = (Button)btnsender;
                    CurrentBtn.BackColor = color;
                    CurrentBtn.ForeColor = Color.White;
                    CurrentBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(childForm);
            this.PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void ppbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form1(), sender);

        }

        private void rosterbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form2(), sender);
        }
        private void discbtn_Click(object sender, EventArgs e)
        {


            OpenChildForm(new Forms.Form3(), sender);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Forms.Form4 childForm = new Forms.Form4();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(childForm);
            this.PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}

