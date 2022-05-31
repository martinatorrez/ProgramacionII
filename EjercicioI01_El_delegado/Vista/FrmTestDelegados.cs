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
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizadorNombre(string nombre);
        private ActualizadorNombre actualizadorNombre;
        public FrmTestDelegados(ActualizadorNombre actualizado)
        {
            InitializeComponent();
            actualizadorNombre = actualizado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizadorNombre.Invoke(this.txtNombre.Text);
        }
    }
}
