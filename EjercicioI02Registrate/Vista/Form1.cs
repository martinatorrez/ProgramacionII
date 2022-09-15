using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmRegistro : Form
    {
        
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Ingresante ingresante = new Ingresante(this.txtBoxNombre.Text, this.txtBoxDireccion.Text, GeneroSeleccionado(),  this.lstBoxPais.Text, CursosSeleccionados(), (int)this.nmericEdad.Value);
            MessageBox.Show(ingresante.Mostrar());
        }

        private string GeneroSeleccionado()
        {
            string genero;

            if (this.radioButton1.Checked)
            {
                genero = "Femenino";
            }
            else if (this.radioBtnMasculino.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "No Binario";
            }
            return genero;
        }
        private string[] CursosSeleccionados()
        {
            string[] cursos=new string[3];
            if (this.checkBoxc.Checked)
            {
                cursos[0]="C#";
            }
            if (this.checkBox1.Checked)
            {
                cursos[1] = "C++";
            }
            if (this.checkBoxJava.Checked)
            {
                cursos[2] = "JavaScript";
            }
            return cursos;
        }
    }
}
