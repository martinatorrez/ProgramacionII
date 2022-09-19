namespace Vista
{
    partial class FrmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxDetalles = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nmericEdad = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.grpBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxJava = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxc = new System.Windows.Forms.CheckBox();
            this.lstBoxPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grpBoxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmericEdad)).BeginInit();
            this.grpBoxGenero.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDetalles
            // 
            this.grpBoxDetalles.Controls.Add(this.lblEdad);
            this.grpBoxDetalles.Controls.Add(this.lblDireccion);
            this.grpBoxDetalles.Controls.Add(this.lblNombre);
            this.grpBoxDetalles.Controls.Add(this.nmericEdad);
            this.grpBoxDetalles.Controls.Add(this.txtBoxDireccion);
            this.grpBoxDetalles.Controls.Add(this.txtBoxNombre);
            this.grpBoxDetalles.Location = new System.Drawing.Point(115, 25);
            this.grpBoxDetalles.Name = "grpBoxDetalles";
            this.grpBoxDetalles.Size = new System.Drawing.Size(223, 180);
            this.grpBoxDetalles.TabIndex = 0;
            this.grpBoxDetalles.TabStop = false;
            this.grpBoxDetalles.Text = "Detalles del usuario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(24, 131);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(23, 84);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // nmericEdad
            // 
            this.nmericEdad.Location = new System.Drawing.Point(90, 130);
            this.nmericEdad.Name = "nmericEdad";
            this.nmericEdad.Size = new System.Drawing.Size(107, 23);
            this.nmericEdad.TabIndex = 2;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(87, 82);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(111, 23);
            this.txtBoxDireccion.TabIndex = 1;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(87, 38);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(111, 23);
            this.txtBoxNombre.TabIndex = 0;
            // 
            // grpBoxGenero
            // 
            this.grpBoxGenero.Controls.Add(this.radioButton2);
            this.grpBoxGenero.Controls.Add(this.radioButton1);
            this.grpBoxGenero.Controls.Add(this.radioBtnMasculino);
            this.grpBoxGenero.Location = new System.Drawing.Point(537, 50);
            this.grpBoxGenero.Name = "grpBoxGenero";
            this.grpBoxGenero.Size = new System.Drawing.Size(128, 127);
            this.grpBoxGenero.TabIndex = 1;
            this.grpBoxGenero.TabStop = false;
            this.grpBoxGenero.Text = "Genero";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No binario";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Femenino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.Location = new System.Drawing.Point(23, 26);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioBtnMasculino.TabIndex = 0;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxJava);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBoxc);
            this.groupBox1.Location = new System.Drawing.Point(535, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursos";
            // 
            // checkBoxJava
            // 
            this.checkBoxJava.AutoSize = true;
            this.checkBoxJava.Location = new System.Drawing.Point(36, 83);
            this.checkBoxJava.Name = "checkBoxJava";
            this.checkBoxJava.Size = new System.Drawing.Size(78, 19);
            this.checkBoxJava.TabIndex = 2;
            this.checkBoxJava.Text = "JavaScript";
            this.checkBoxJava.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "C++";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxc
            // 
            this.checkBoxc.AutoSize = true;
            this.checkBoxc.Location = new System.Drawing.Point(36, 33);
            this.checkBoxc.Name = "checkBoxc";
            this.checkBoxc.Size = new System.Drawing.Size(41, 19);
            this.checkBoxc.TabIndex = 0;
            this.checkBoxc.Text = "C#";
            this.checkBoxc.UseVisualStyleBackColor = true;
            // 
            // lstBoxPais
            // 
            this.lstBoxPais.FormattingEnabled = true;
            this.lstBoxPais.ItemHeight = 15;
            this.lstBoxPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lstBoxPais.Location = new System.Drawing.Point(115, 259);
            this.lstBoxPais.Name = "lstBoxPais";
            this.lstBoxPais.Size = new System.Drawing.Size(223, 79);
            this.lstBoxPais.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(114, 241);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(522, 348);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(152, 35);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 390);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lstBoxPais);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxGenero);
            this.Controls.Add(this.grpBoxDetalles);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.grpBoxDetalles.ResumeLayout(false);
            this.grpBoxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmericEdad)).EndInit();
            this.grpBoxGenero.ResumeLayout(false);
            this.grpBoxGenero.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDetalles;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nmericEdad;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.GroupBox grpBoxGenero;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxJava;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxc;
        private System.Windows.Forms.ListBox lstBoxPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}
