namespace AMACC_CEBU_LIBRARY_SYSTEM
{
    partial class Options
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
            this.btnMempanel = new System.Windows.Forms.Button();
            this.btnBooktrans = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkAdmin = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMempanel
            // 
            this.btnMempanel.Location = new System.Drawing.Point(17, 77);
            this.btnMempanel.Name = "btnMempanel";
            this.btnMempanel.Size = new System.Drawing.Size(159, 201);
            this.btnMempanel.TabIndex = 0;
            this.btnMempanel.Text = "Members Panel";
            this.btnMempanel.UseVisualStyleBackColor = true;
            this.btnMempanel.Click += new System.EventHandler(this.btnMempanel_Click);
            // 
            // btnBooktrans
            // 
            this.btnBooktrans.Location = new System.Drawing.Point(202, 77);
            this.btnBooktrans.Name = "btnBooktrans";
            this.btnBooktrans.Size = new System.Drawing.Size(159, 201);
            this.btnBooktrans.TabIndex = 1;
            this.btnBooktrans.Text = "Book Transactions";
            this.btnBooktrans.UseVisualStyleBackColor = true;
            this.btnBooktrans.Click += new System.EventHandler(this.btnBooktrans_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lnkAdmin);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 25);
            this.panel1.TabIndex = 2;
            // 
            // lnkAdmin
            // 
            this.lnkAdmin.AutoSize = true;
            this.lnkAdmin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkAdmin.LinkColor = System.Drawing.Color.Black;
            this.lnkAdmin.Location = new System.Drawing.Point(319, 6);
            this.lnkAdmin.Name = "lnkAdmin";
            this.lnkAdmin.Size = new System.Drawing.Size(36, 13);
            this.lnkAdmin.TabIndex = 3;
            this.lnkAdmin.TabStop = true;
            this.lnkAdmin.Text = "Admin";
            this.lnkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdmin_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(68, 6);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(29, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Help";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(34, 6);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(30, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(8, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(23, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "File";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(377, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBooktrans);
            this.Controls.Add(this.btnMempanel);
            this.Name = "Options";
            this.Text = "Options";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMempanel;
        private System.Windows.Forms.Button btnBooktrans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnkAdmin;
    }
}