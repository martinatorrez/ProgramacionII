using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI01WindowsForm
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox2.Text) && string.IsNullOrWhiteSpace(this.textBox1.Text)) 
            {
                MessageBox.Show($"Se deben completar los siguientes campos \n Nombre\n Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                MessageBox.Show($"Se deben completar los siguientes campos \n Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(this.textBox1.Text)) 
            {
                MessageBox.Show($"Se deben completar los siguientes campos \n Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                FrmSaludo frm = new FrmSaludo("Hola Windows Form!", $"Soy {this.textBox1.Text} {this.textBox2.Text} y mi materia favorita es: {this.cmbMaterias.SelectedItem}");
                frm.ShowDialog();
                
            }
            
            
        }

        private void FrmSaludar_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.Items.Add("Programacion I");
            this.cmbMaterias.Items.Add("Labo I");
            this.cmbMaterias.Items.Add("Spd");
            this.cmbMaterias.Items.Add("Ingles");
            this.cmbMaterias.Items.Add("Programacion II");
            this.cmbMaterias.Items.Add("Labo II");
            this.cmbMaterias.Items.Add("Estadistica");
            this.cmbMaterias.SelectedIndex = 0;
        }
    }
}
