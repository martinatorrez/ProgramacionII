using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        FrmMostrar mostrar;
        FrmTestDelegados frmDelegados;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.mostrar = new FrmMostrar();
            this.frmDelegados = new FrmTestDelegados(mostrar.ActualizarNombre);
            mostrar.MdiParent = this;
            
            frmDelegados.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelegados.Show();
            this.menuStrip1.Enabled = false;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar.Show();
        }
    }
}
