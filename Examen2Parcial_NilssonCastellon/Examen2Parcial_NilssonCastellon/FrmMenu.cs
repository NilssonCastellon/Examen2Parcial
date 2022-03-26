using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2Parcial_NilssonCastellon
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

        
        

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           FrmUsuarios frm = new FrmUsuarios();

            frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmProductocs frm = new FrmProductocs();
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmPedidos frm = new FrmPedidos();
            frm.Show();
        }
    }
}
