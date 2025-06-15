namespace AlgoritmoLineas
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRESENHAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELLENODEFIGURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bRESENHAMToolStripMenuItem,
            this.bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem,
            this.rELLENODEFIGURASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bRESENHAMToolStripMenuItem
            // 
            this.bRESENHAMToolStripMenuItem.Name = "bRESENHAMToolStripMenuItem";
            this.bRESENHAMToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.bRESENHAMToolStripMenuItem.Text = "BRESENHAM";
            this.bRESENHAMToolStripMenuItem.Click += new System.EventHandler(this.bRESENHAMToolStripMenuItem_Click);
            // 
            // bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem
            // 
            this.bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem.Name = "bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem";
            this.bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem.Text = "BRESENHAM PARA CIRCUNFERENCIAS";
            this.bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem.Click += new System.EventHandler(this.bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem_Click);
            // 
            // rELLENODEFIGURASToolStripMenuItem
            // 
            this.rELLENODEFIGURASToolStripMenuItem.Name = "rELLENODEFIGURASToolStripMenuItem";
            this.rELLENODEFIGURASToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.rELLENODEFIGURASToolStripMenuItem.Text = "RELLENO DE FIGURAS";
            this.rELLENODEFIGURASToolStripMenuItem.Click += new System.EventHandler(this.rELLENODEFIGURASToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1110, 725);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRESENHAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELLENODEFIGURASToolStripMenuItem;
    }
}