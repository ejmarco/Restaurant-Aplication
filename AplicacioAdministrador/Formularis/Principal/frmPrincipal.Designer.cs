namespace AplicacioAdministrador.Formularis.Principal
{
    partial class frmPrincipal
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblAltaProducte = new System.Windows.Forms.Label();
            this.lblModificarProducte = new System.Windows.Forms.Label();
            this.lblAltaMenu = new System.Windows.Forms.Label();
            this.lblModificarMenu = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pbBtnMinimizeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnMinimizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 126);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(971, 567);
            this.pnlPrincipal.TabIndex = 12;
            // 
            // lblAltaProducte
            // 
            this.lblAltaProducte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaProducte.ForeColor = System.Drawing.Color.White;
            this.lblAltaProducte.Location = new System.Drawing.Point(1056, 126);
            this.lblAltaProducte.Name = "lblAltaProducte";
            this.lblAltaProducte.Size = new System.Drawing.Size(120, 71);
            this.lblAltaProducte.TabIndex = 8;
            this.lblAltaProducte.Text = "Alta Producte";
            this.lblAltaProducte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAltaProducte.Click += new System.EventHandler(this.lblAltaProducte_Click);
            this.lblAltaProducte.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.lblAltaProducte.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // lblModificarProducte
            // 
            this.lblModificarProducte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarProducte.ForeColor = System.Drawing.Color.White;
            this.lblModificarProducte.Location = new System.Drawing.Point(1056, 257);
            this.lblModificarProducte.Name = "lblModificarProducte";
            this.lblModificarProducte.Size = new System.Drawing.Size(120, 71);
            this.lblModificarProducte.TabIndex = 9;
            this.lblModificarProducte.Text = "Modificar Producte";
            this.lblModificarProducte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblModificarProducte.Click += new System.EventHandler(this.lblModificarProducte_Click);
            this.lblModificarProducte.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.lblModificarProducte.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // lblAltaMenu
            // 
            this.lblAltaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaMenu.ForeColor = System.Drawing.Color.White;
            this.lblAltaMenu.Location = new System.Drawing.Point(1056, 372);
            this.lblAltaMenu.Name = "lblAltaMenu";
            this.lblAltaMenu.Size = new System.Drawing.Size(120, 71);
            this.lblAltaMenu.TabIndex = 10;
            this.lblAltaMenu.Text = "Alta Menu";
            this.lblAltaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAltaMenu.Click += new System.EventHandler(this.lblAltaMenu_Click);
            this.lblAltaMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.lblAltaMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // lblModificarMenu
            // 
            this.lblModificarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarMenu.ForeColor = System.Drawing.Color.White;
            this.lblModificarMenu.Location = new System.Drawing.Point(1056, 495);
            this.lblModificarMenu.Name = "lblModificarMenu";
            this.lblModificarMenu.Size = new System.Drawing.Size(120, 71);
            this.lblModificarMenu.TabIndex = 11;
            this.lblModificarMenu.Text = "Modificar Menu";
            this.lblModificarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblModificarMenu.Click += new System.EventHandler(this.lblModificarMenu_Click);
            this.lblModificarMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.lblModificarMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(724, 69);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Nom Usuari";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::AplicacioAdministrador.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(1246, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 57);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 14;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pbBtnMinimizeBox
            // 
            this.pbBtnMinimizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnMinimizeBox.Image = global::AplicacioAdministrador.Properties.Resources.MinimizeBox;
            this.pbBtnMinimizeBox.Location = new System.Drawing.Point(1185, 21);
            this.pbBtnMinimizeBox.Name = "pbBtnMinimizeBox";
            this.pbBtnMinimizeBox.Size = new System.Drawing.Size(55, 57);
            this.pbBtnMinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnMinimizeBox.TabIndex = 11;
            this.pbBtnMinimizeBox.TabStop = false;
            this.pbBtnMinimizeBox.Click += new System.EventHandler(this.pbBtnMinimizeBox_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1304, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAltaProducte);
            this.Controls.Add(this.lblModificarProducte);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.lblAltaMenu);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblModificarMenu);
            this.Controls.Add(this.pbBtnMinimizeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnMinimizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBtnMinimizeBox;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAltaProducte;
        private System.Windows.Forms.Label lblModificarProducte;
        private System.Windows.Forms.Label lblAltaMenu;
        private System.Windows.Forms.Label lblModificarMenu;
        private System.Windows.Forms.PictureBox btnClose;
    }
}