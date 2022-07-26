namespace WindowsFormsApp1.Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.newrank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.promotion = new System.Windows.Forms.Button();
            this.demotion = new System.Windows.Forms.Button();
            this.stepdown = new System.Windows.Forms.Button();
            this.termination = new System.Windows.Forms.Button();
            this.supervisor = new System.Windows.Forms.Button();
            this.asstcmder = new System.Windows.Forms.Button();
            this.cmder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.div = new System.Windows.Forms.TextBox();
            this.resigned = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cntry = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(405, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roster Updates";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(131, 20);
            this.name.TabIndex = 1;
            // 
            // newrank
            // 
            this.newrank.Location = new System.Drawing.Point(320, 158);
            this.newrank.Name = "newrank";
            this.newrank.Size = new System.Drawing.Size(136, 20);
            this.newrank.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Rank";
            // 
            // promotion
            // 
            this.promotion.BackColor = System.Drawing.Color.Lime;
            this.promotion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotion.ForeColor = System.Drawing.Color.Black;
            this.promotion.Location = new System.Drawing.Point(29, 435);
            this.promotion.Name = "promotion";
            this.promotion.Size = new System.Drawing.Size(134, 53);
            this.promotion.TabIndex = 3;
            this.promotion.Text = "Promotion";
            this.promotion.UseVisualStyleBackColor = false;
            this.promotion.Click += new System.EventHandler(this.button1_Click);
            // 
            // demotion
            // 
            this.demotion.BackColor = System.Drawing.Color.Red;
            this.demotion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demotion.ForeColor = System.Drawing.Color.Black;
            this.demotion.Location = new System.Drawing.Point(166, 496);
            this.demotion.Name = "demotion";
            this.demotion.Size = new System.Drawing.Size(134, 53);
            this.demotion.TabIndex = 3;
            this.demotion.Text = "Demotion";
            this.demotion.UseVisualStyleBackColor = false;
            this.demotion.Click += new System.EventHandler(this.demotion_Click);
            // 
            // stepdown
            // 
            this.stepdown.BackColor = System.Drawing.Color.Red;
            this.stepdown.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepdown.ForeColor = System.Drawing.Color.Black;
            this.stepdown.Location = new System.Drawing.Point(309, 496);
            this.stepdown.Name = "stepdown";
            this.stepdown.Size = new System.Drawing.Size(134, 53);
            this.stepdown.TabIndex = 3;
            this.stepdown.Text = "Stepdown";
            this.stepdown.UseVisualStyleBackColor = false;
            this.stepdown.Click += new System.EventHandler(this.stepdown_Click);
            // 
            // termination
            // 
            this.termination.BackColor = System.Drawing.Color.Red;
            this.termination.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termination.ForeColor = System.Drawing.Color.Black;
            this.termination.Location = new System.Drawing.Point(29, 496);
            this.termination.Name = "termination";
            this.termination.Size = new System.Drawing.Size(134, 53);
            this.termination.TabIndex = 3;
            this.termination.Text = "Termination";
            this.termination.UseVisualStyleBackColor = false;
            this.termination.Click += new System.EventHandler(this.termination_Click);
            // 
            // supervisor
            // 
            this.supervisor.BackColor = System.Drawing.Color.Lime;
            this.supervisor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisor.ForeColor = System.Drawing.Color.Black;
            this.supervisor.Location = new System.Drawing.Point(169, 437);
            this.supervisor.Name = "supervisor";
            this.supervisor.Size = new System.Drawing.Size(134, 53);
            this.supervisor.TabIndex = 3;
            this.supervisor.Text = "Divisional Promotion  -  Supervisor";
            this.supervisor.UseVisualStyleBackColor = false;
            this.supervisor.Click += new System.EventHandler(this.supervisor_Click);
            // 
            // asstcmder
            // 
            this.asstcmder.BackColor = System.Drawing.Color.Lime;
            this.asstcmder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asstcmder.ForeColor = System.Drawing.Color.Black;
            this.asstcmder.Location = new System.Drawing.Point(309, 437);
            this.asstcmder.Name = "asstcmder";
            this.asstcmder.Size = new System.Drawing.Size(134, 53);
            this.asstcmder.TabIndex = 3;
            this.asstcmder.Text = "Divisional Promotion  - Assistant Commander\r\n";
            this.asstcmder.UseVisualStyleBackColor = false;
            this.asstcmder.Click += new System.EventHandler(this.asstcmder_Click);
            // 
            // cmder
            // 
            this.cmder.BackColor = System.Drawing.Color.Lime;
            this.cmder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmder.ForeColor = System.Drawing.Color.Black;
            this.cmder.Location = new System.Drawing.Point(449, 437);
            this.cmder.Name = "cmder";
            this.cmder.Size = new System.Drawing.Size(134, 53);
            this.cmder.TabIndex = 3;
            this.cmder.Text = "Divisional Promotion  - Commander\r\n";
            this.cmder.UseVisualStyleBackColor = false;
            this.cmder.Click += new System.EventHandler(this.cmder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(168, 158);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(132, 20);
            this.date.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Division";
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(481, 158);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(125, 20);
            this.div.TabIndex = 1;
            // 
            // resigned
            // 
            this.resigned.BackColor = System.Drawing.Color.Red;
            this.resigned.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resigned.ForeColor = System.Drawing.Color.Black;
            this.resigned.Location = new System.Drawing.Point(449, 496);
            this.resigned.Name = "resigned";
            this.resigned.Size = new System.Drawing.Size(134, 53);
            this.resigned.TabIndex = 3;
            this.resigned.Text = "Resignation";
            this.resigned.UseVisualStyleBackColor = false;
            this.resigned.Click += new System.EventHandler(this.resigned_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(668, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Country";
            // 
            // cntry
            // 
            this.cntry.Location = new System.Drawing.Point(648, 158);
            this.cntry.Name = "cntry";
            this.cntry.Size = new System.Drawing.Size(125, 20);
            this.cntry.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(729, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate a Corporal + Code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.files;
            this.panel2.Location = new System.Drawing.Point(337, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 66);
            this.panel2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 559);
            this.Controls.Add(this.resigned);
            this.Controls.Add(this.stepdown);
            this.Controls.Add(this.demotion);
            this.Controls.Add(this.termination);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmder);
            this.Controls.Add(this.asstcmder);
            this.Controls.Add(this.supervisor);
            this.Controls.Add(this.promotion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cntry);
            this.Controls.Add(this.div);
            this.Controls.Add(this.newrank);
            this.Controls.Add(this.date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Roster Updates";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox newrank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button promotion;
        private System.Windows.Forms.Button demotion;
        private System.Windows.Forms.Button stepdown;
        private System.Windows.Forms.Button termination;
        private System.Windows.Forms.Button supervisor;
        private System.Windows.Forms.Button asstcmder;
        private System.Windows.Forms.Button cmder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox div;
        private System.Windows.Forms.Button resigned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cntry;
        private System.Windows.Forms.Button button1;
    }
}