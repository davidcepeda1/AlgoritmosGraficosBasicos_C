using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlgoritmoLineas
{
    public partial class FrmHome : Form
    {


        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDDA dda = FrmDDA.SingletonInstancia();
            dda.MdiParent = this;
            dda.Show();
        }
        public FrmHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void bRESENHAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBresenham bresenham = FrmBresenham.SingletonInstancia();
            bresenham.MdiParent = this;
            bresenham.Show();
        }

        private void bRESENHAMPARACIRCUNFERENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBresenhamCircunferencias bresenhamCirculo = FrmBresenhamCircunferencias.SingletonInstancia();
            bresenhamCirculo.MdiParent = this;
            bresenhamCirculo.Show();
        }

        private void rELLENODEFIGURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRellenoFiguras floodFill = FrmRellenoFiguras.SingletonInstancia();
            floodFill.MdiParent = this;
            floodFill.Show();
        }
    }
}
