namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.discbtn = new System.Windows.Forms.Button();
            this.rosterbtn = new System.Windows.Forms.Button();
            this.ppbtn = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.discbtn);
            this.panelMenu.Controls.Add(this.rosterbtn);
            this.panelMenu.Controls.Add(this.ppbtn);
            this.panelMenu.ForeColor = System.Drawing.Color.Gray;
            this.panelMenu.Location = new System.Drawing.Point(1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(315, 772);
            this.panelMenu.TabIndex = 0;
            // 
            // PanelMain
            // 
            this.PanelMain.Location = new System.Drawing.Point(315, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1066, 598);
            this.PanelMain.TabIndex = 1;
            // 
            // discbtn
            // 
            this.discbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.discbtn.FlatAppearance.BorderSize = 0;
            this.discbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discbtn.ForeColor = System.Drawing.Color.MintCream;
            this.discbtn.Image = global::WindowsFormsApp1.Properties.Resources.discord;
            this.discbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discbtn.Location = new System.Drawing.Point(3, 170);
            this.discbtn.Name = "discbtn";
            this.discbtn.Size = new System.Drawing.Size(308, 95);
            this.discbtn.TabIndex = 1;
            this.discbtn.Text = "Discord Updates";
            this.discbtn.UseVisualStyleBackColor = false;
            this.discbtn.Click += new System.EventHandler(this.discbtn_Click);
            // 
            // rosterbtn
            // 
            this.rosterbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rosterbtn.FlatAppearance.BorderSize = 0;
            this.rosterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rosterbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosterbtn.ForeColor = System.Drawing.Color.MintCream;
            this.rosterbtn.Image = global::WindowsFormsApp1.Properties.Resources.files;
            this.rosterbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rosterbtn.Location = new System.Drawing.Point(0, 90);
            this.rosterbtn.Name = "rosterbtn";
            this.rosterbtn.Size = new System.Drawing.Size(315, 84);
            this.rosterbtn.TabIndex = 1;
            this.rosterbtn.Text = "Roster Updates";
            this.rosterbtn.UseVisualStyleBackColor = false;
            this.rosterbtn.Click += new System.EventHandler(this.rosterbtn_Click);
            // 
            // ppbtn
            // 
            this.ppbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ppbtn.FlatAppearance.BorderSize = 0;
            this.ppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ppbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppbtn.ForeColor = System.Drawing.Color.MintCream;
            this.ppbtn.Image = global::WindowsFormsApp1.Properties.Resources.files1;
            this.ppbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ppbtn.Location = new System.Drawing.Point(0, 3);
            this.ppbtn.Name = "ppbtn";
            this.ppbtn.Size = new System.Drawing.Size(311, 81);
            this.ppbtn.TabIndex = 1;
            this.ppbtn.Text = "Personnel Profiles";
            this.ppbtn.UseVisualStyleBackColor = false;
            this.ppbtn.Click += new System.EventHandler(this.ppbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 599);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "H.R Templates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button ppbtn;
        private System.Windows.Forms.Button rosterbtn;
        private System.Windows.Forms.Button discbtn;
        private System.Windows.Forms.Panel PanelMain;
    }
}

