namespace AplicacioAdministrador.Formularis.Login
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblContrasenya = new System.Windows.Forms.Label();
            this.txbUsuari = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnTancar = new System.Windows.Forms.PictureBox();
            this.pbBtnMinimizeBox = new System.Windows.Forms.PictureBox();
            this.lblBtnLogin = new System.Windows.Forms.Label();
            this.btnAmagat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnTancar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnMinimizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(49, 57);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Usuari: ";
            // 
            // lblContrasenya
            // 
            this.lblContrasenya.AutoSize = true;
            this.lblContrasenya.ForeColor = System.Drawing.Color.White;
            this.lblContrasenya.Location = new System.Drawing.Point(49, 91);
            this.lblContrasenya.Name = "lblContrasenya";
            this.lblContrasenya.Size = new System.Drawing.Size(80, 13);
            this.lblContrasenya.TabIndex = 1;
            this.lblContrasenya.Text = "Contrassenya:  ";
            // 
            // txbUsuari
            // 
            this.txbUsuari.Location = new System.Drawing.Point(135, 57);
            this.txbUsuari.Name = "txbUsuari";
            this.txbUsuari.Size = new System.Drawing.Size(100, 20);
            this.txbUsuari.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(135, 88);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(100, 22);
            this.txbPassword.TabIndex = 3;
            // 
            // btnTancar
            // 
            this.btnTancar.BackColor = System.Drawing.Color.Transparent;
            this.btnTancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTancar.Image = ((System.Drawing.Image)(resources.GetObject("btnTancar.Image")));
            this.btnTancar.Location = new System.Drawing.Point(345, 12);
            this.btnTancar.Name = "btnTancar";
            this.btnTancar.Size = new System.Drawing.Size(34, 37);
            this.btnTancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTancar.TabIndex = 12;
            this.btnTancar.TabStop = false;
            this.btnTancar.Click += new System.EventHandler(this.btnTancar_Click);
            // 
            // pbBtnMinimizeBox
            // 
            this.pbBtnMinimizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnMinimizeBox.Image = global::AplicacioAdministrador.Properties.Resources.MinimizeBox;
            this.pbBtnMinimizeBox.Location = new System.Drawing.Point(305, 22);
            this.pbBtnMinimizeBox.Name = "pbBtnMinimizeBox";
            this.pbBtnMinimizeBox.Size = new System.Drawing.Size(34, 37);
            this.pbBtnMinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnMinimizeBox.TabIndex = 13;
            this.pbBtnMinimizeBox.TabStop = false;
            this.pbBtnMinimizeBox.Click += new System.EventHandler(this.pbBtnMinimizeBox_Click);
            // 
            // lblBtnLogin
            // 
            this.lblBtnLogin.AutoSize = true;
            this.lblBtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnLogin.ForeColor = System.Drawing.Color.White;
            this.lblBtnLogin.Location = new System.Drawing.Point(269, 134);
            this.lblBtnLogin.Name = "lblBtnLogin";
            this.lblBtnLogin.Size = new System.Drawing.Size(70, 25);
            this.lblBtnLogin.TabIndex = 17;
            this.lblBtnLogin.Text = "Login";
            this.lblBtnLogin.Click += new System.EventHandler(this.lblBtnLogin_Click);
            this.lblBtnLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBtnLogin_MouseDown);
            this.lblBtnLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBtnLogin_MouseUp);
            // 
            // btnAmagat
            // 
            this.btnAmagat.Location = new System.Drawing.Point(17, 152);
            this.btnAmagat.Name = "btnAmagat";
            this.btnAmagat.Size = new System.Drawing.Size(26, 23);
            this.btnAmagat.TabIndex = 18;
            this.btnAmagat.Text = "button1";
            this.btnAmagat.UseVisualStyleBackColor = true;
            this.btnAmagat.Visible = false;
            this.btnAmagat.Click += new System.EventHandler(this.btnAmagat_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(391, 187);
            this.Controls.Add(this.btnAmagat);
            this.Controls.Add(this.lblBtnLogin);
            this.Controls.Add(this.pbBtnMinimizeBox);
            this.Controls.Add(this.btnTancar);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsuari);
            this.Controls.Add(this.lblContrasenya);
            this.Controls.Add(this.lblLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnTancar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnMinimizeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblContrasenya;
        private System.Windows.Forms.TextBox txbUsuari;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.PictureBox btnTancar;
        private System.Windows.Forms.PictureBox pbBtnMinimizeBox;
        private System.Windows.Forms.Label lblBtnLogin;
        private System.Windows.Forms.Button btnAmagat;
    }
}