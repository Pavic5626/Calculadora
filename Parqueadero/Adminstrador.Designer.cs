namespace Parqueadero
{
    partial class Adminstrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreAdmin = new System.Windows.Forms.TextBox();
            this.TxtCedulaAdmin = new System.Windows.Forms.TextBox();
            this.CmbTurno = new System.Windows.Forms.ComboBox();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Turno";
            // 
            // TxtNombreAdmin
            // 
            this.TxtNombreAdmin.Location = new System.Drawing.Point(295, 34);
            this.TxtNombreAdmin.Name = "TxtNombreAdmin";
            this.TxtNombreAdmin.Size = new System.Drawing.Size(167, 20);
            this.TxtNombreAdmin.TabIndex = 4;
            // 
            // TxtCedulaAdmin
            // 
            this.TxtCedulaAdmin.Location = new System.Drawing.Point(295, 63);
            this.TxtCedulaAdmin.Name = "TxtCedulaAdmin";
            this.TxtCedulaAdmin.PasswordChar = '*';
            this.TxtCedulaAdmin.Size = new System.Drawing.Size(167, 20);
            this.TxtCedulaAdmin.TabIndex = 5;
            // 
            // CmbTurno
            // 
            this.CmbTurno.FormattingEnabled = true;
            this.CmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.CmbTurno.Location = new System.Drawing.Point(295, 95);
            this.CmbTurno.Name = "CmbTurno";
            this.CmbTurno.Size = new System.Drawing.Size(167, 21);
            this.CmbTurno.TabIndex = 9;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(322, 132);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(110, 38);
            this.BtnAdmin.TabIndex = 10;
            this.BtnAdmin.Text = "&Inicio";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(9, 163);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@Joan_Robles";
            // 
            // Adminstrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 182);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.CmbTurno);
            this.Controls.Add(this.TxtCedulaAdmin);
            this.Controls.Add(this.TxtNombreAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adminstrador";
            this.Text = "Adminstrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombreAdmin;
        private System.Windows.Forms.TextBox TxtCedulaAdmin;
        private System.Windows.Forms.ComboBox CmbTurno;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}