namespace Parqueadero
{
    partial class Registro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.lblParqueadero = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Marca:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(142, 114);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(177, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(447, 114);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(156, 20);
            this.TxtCedula.TabIndex = 7;
            this.TxtCedula.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CmbMarca
            // 
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Items.AddRange(new object[] {
            "Renault",
            "Mazda",
            "Volkswagen",
            "Chevrolet",
            "Kia",
            "Hyundai",
            "Honda",
            "Ford"});
            this.CmbMarca.Location = new System.Drawing.Point(447, 142);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(156, 21);
            this.CmbMarca.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "&Matricula:";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(142, 140);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(177, 20);
            this.TxtMatricula.TabIndex = 10;
            // 
            // lblParqueadero
            // 
            this.lblParqueadero.AutoSize = true;
            this.lblParqueadero.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParqueadero.Location = new System.Drawing.Point(256, 35);
            this.lblParqueadero.Name = "lblParqueadero";
            this.lblParqueadero.Size = new System.Drawing.Size(161, 49);
            this.lblParqueadero.TabIndex = 0;
            this.lblParqueadero.Text = "Registro";
            this.lblParqueadero.Click += new System.EventHandler(this.lblParqueadero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "&Color:";
            // 
            // CmbColor
            // 
            this.CmbColor.FormattingEnabled = true;
            this.CmbColor.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Negro",
            "Blanco",
            "Amarillo"});
            this.CmbColor.Location = new System.Drawing.Point(447, 169);
            this.CmbColor.Name = "CmbColor";
            this.CmbColor.Size = new System.Drawing.Size(156, 21);
            this.CmbColor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "&Modelo:";
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(142, 169);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(177, 20);
            this.TxtModelo.TabIndex = 15;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(164, 222);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(92, 38);
            this.BtnIngresar.TabIndex = 24;
            this.BtnIngresar.Text = "&Ingresar Vehiculo";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.Location = new System.Drawing.Point(283, 222);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(92, 38);
            this.BtnRetirar.TabIndex = 25;
            this.BtnRetirar.Text = "&Retirar Vehiculo";
            this.BtnRetirar.UseVisualStyleBackColor = true;
            this.BtnRetirar.Click += new System.EventHandler(this.BtnRetirar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(502, 222);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(92, 38);
            this.BtnSalir.TabIndex = 27;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnPagar
            // 
            this.BtnPagar.Location = new System.Drawing.Point(394, 222);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(92, 38);
            this.BtnPagar.TabIndex = 28;
            this.BtnPagar.Text = "&Pagar";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 285);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnRetirar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbMarca);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParqueadero);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Se Lo Cuidamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label lblParqueadero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnRetirar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnPagar;
    }
}

