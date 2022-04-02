namespace Hakatonb
{
    partial class KorisnikHomePage
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
            this.noviPosaoDugme = new System.Windows.Forms.Button();
            this.logoutDugme = new System.Windows.Forms.Button();
            this.PravljenjePosla = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.finalnoPravljenjePoslaDugme = new System.Windows.Forms.Button();
            this.skillsetPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PravljenjePosla.SuspendLayout();
            this.skillsetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // noviPosaoDugme
            // 
            this.noviPosaoDugme.Location = new System.Drawing.Point(12, 22);
            this.noviPosaoDugme.Name = "noviPosaoDugme";
            this.noviPosaoDugme.Size = new System.Drawing.Size(214, 82);
            this.noviPosaoDugme.TabIndex = 0;
            this.noviPosaoDugme.Text = "Napravi novi posao";
            this.noviPosaoDugme.UseVisualStyleBackColor = true;
            this.noviPosaoDugme.Click += new System.EventHandler(this.noviPosaoDugme_Click);
            // 
            // logoutDugme
            // 
            this.logoutDugme.Location = new System.Drawing.Point(18, 405);
            this.logoutDugme.Name = "logoutDugme";
            this.logoutDugme.Size = new System.Drawing.Size(75, 23);
            this.logoutDugme.TabIndex = 1;
            this.logoutDugme.Text = "Izloguj se";
            this.logoutDugme.UseVisualStyleBackColor = true;
            this.logoutDugme.Click += new System.EventHandler(this.logoutDugme_Click);
            // 
            // PravljenjePosla
            // 
            this.PravljenjePosla.Controls.Add(this.label1);
            this.PravljenjePosla.Controls.Add(this.textBox1);
            this.PravljenjePosla.Controls.Add(this.finalnoPravljenjePoslaDugme);
            this.PravljenjePosla.Controls.Add(this.skillsetPanel);
            this.PravljenjePosla.Location = new System.Drawing.Point(8, 119);
            this.PravljenjePosla.Name = "PravljenjePosla";
            this.PravljenjePosla.Size = new System.Drawing.Size(218, 254);
            this.PravljenjePosla.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Naslov:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 19;
            // 
            // finalnoPravljenjePoslaDugme
            // 
            this.finalnoPravljenjePoslaDugme.Location = new System.Drawing.Point(27, 192);
            this.finalnoPravljenjePoslaDugme.Name = "finalnoPravljenjePoslaDugme";
            this.finalnoPravljenjePoslaDugme.Size = new System.Drawing.Size(150, 52);
            this.finalnoPravljenjePoslaDugme.TabIndex = 18;
            this.finalnoPravljenjePoslaDugme.Text = "Napravi";
            this.finalnoPravljenjePoslaDugme.UseVisualStyleBackColor = true;
            this.finalnoPravljenjePoslaDugme.Click += new System.EventHandler(this.finalnoPravljenjePoslaDugme_Click);
            // 
            // skillsetPanel
            // 
            this.skillsetPanel.Controls.Add(this.label7);
            this.skillsetPanel.Controls.Add(this.cb4);
            this.skillsetPanel.Controls.Add(this.cb3);
            this.skillsetPanel.Controls.Add(this.cb2);
            this.skillsetPanel.Controls.Add(this.cb1);
            this.skillsetPanel.Location = new System.Drawing.Point(10, 40);
            this.skillsetPanel.Name = "skillsetPanel";
            this.skillsetPanel.Size = new System.Drawing.Size(188, 141);
            this.skillsetPanel.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(49, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Potrebna pomoć";
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(3, 112);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(109, 19);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "Nabavka lekova";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(3, 84);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(99, 19);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "Pomoć u kući";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(3, 59);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(72, 19);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "Nabavka";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(3, 33);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(127, 19);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Medicinska pomoć";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(291, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 349);
            this.listBox1.TabIndex = 4;
            // 
            // KorisnikHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PravljenjePosla);
            this.Controls.Add(this.logoutDugme);
            this.Controls.Add(this.noviPosaoDugme);
            this.Name = "KorisnikHomePage";
            this.Text = "KorisnikHomePage";
            this.Load += new System.EventHandler(this.KorisnikHomePage_Load);
            this.PravljenjePosla.ResumeLayout(false);
            this.PravljenjePosla.PerformLayout();
            this.skillsetPanel.ResumeLayout(false);
            this.skillsetPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button noviPosaoDugme;
        private Button logoutDugme;
        private Panel PravljenjePosla;
        private Button finalnoPravljenjePoslaDugme;
        private Panel skillsetPanel;
        private Label label7;
        private CheckBox cb4;
        private CheckBox cb3;
        private CheckBox cb2;
        private CheckBox cb1;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
    }
}