namespace AplicacioAdministrador.Formularis.Altes
{
    partial class frmAltaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaMenu));
            this.lblDescripcioProducte = new System.Windows.Forms.Label();
            this.txbTitolMenu = new System.Windows.Forms.TextBox();
            this.txbPreu = new System.Windows.Forms.TextBox();
            this.lblPreu = new System.Windows.Forms.Label();
            this.lblEuros = new System.Windows.Forms.Label();
            this.lblEntrants = new System.Windows.Forms.Label();
            this.lblPrimer_Plat = new System.Windows.Forms.Label();
            this.lblSegon_Plat = new System.Windows.Forms.Label();
            this.lblPostres = new System.Windows.Forms.Label();
            this.lblRefresc = new System.Windows.Forms.Label();
            this.lblLicors = new System.Windows.Forms.Label();
            this.lblVi_Blanc = new System.Windows.Forms.Label();
            this.lblVi_Negre = new System.Windows.Forms.Label();
            this.lblVi_Rosat = new System.Windows.Forms.Label();
            this.pnlOpcions = new System.Windows.Forms.Panel();
            this.clbListProductes = new System.Windows.Forms.CheckedListBox();
            this.lblbtnEnrere = new System.Windows.Forms.Label();
            this.lblBtnIntroduir = new System.Windows.Forms.Label();
            this.pnlLinia = new System.Windows.Forms.Panel();
            this.pbDisponibilitat = new System.Windows.Forms.PictureBox();
            this.pbImatgeMenute = new System.Windows.Forms.PictureBox();
            this.pnlOpcions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisponibilitat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImatgeMenute)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcioProducte
            // 
            this.lblDescripcioProducte.AutoSize = true;
            this.lblDescripcioProducte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcioProducte.Location = new System.Drawing.Point(93, 616);
            this.lblDescripcioProducte.Name = "lblDescripcioProducte";
            this.lblDescripcioProducte.Size = new System.Drawing.Size(161, 31);
            this.lblDescripcioProducte.TabIndex = 5;
            this.lblDescripcioProducte.Text = "Descripció:";
            // 
            // txbTitolMenu
            // 
            this.txbTitolMenu.BackColor = System.Drawing.Color.Black;
            this.txbTitolMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTitolMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitolMenu.ForeColor = System.Drawing.Color.White;
            this.txbTitolMenu.Location = new System.Drawing.Point(264, 12);
            this.txbTitolMenu.Name = "txbTitolMenu";
            this.txbTitolMenu.Size = new System.Drawing.Size(474, 40);
            this.txbTitolMenu.TabIndex = 9;
            this.txbTitolMenu.Text = "Titol Menu";
            // 
            // txbPreu
            // 
            this.txbPreu.BackColor = System.Drawing.Color.Black;
            this.txbPreu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPreu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreu.ForeColor = System.Drawing.Color.White;
            this.txbPreu.Location = new System.Drawing.Point(371, 82);
            this.txbPreu.Name = "txbPreu";
            this.txbPreu.Size = new System.Drawing.Size(84, 40);
            this.txbPreu.TabIndex = 11;
            this.txbPreu.Text = "0";
            this.txbPreu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPreu
            // 
            this.lblPreu.AutoSize = true;
            this.lblPreu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreu.Location = new System.Drawing.Point(257, 82);
            this.lblPreu.Name = "lblPreu";
            this.lblPreu.Size = new System.Drawing.Size(105, 39);
            this.lblPreu.TabIndex = 12;
            this.lblPreu.Text = "Preu:";
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuros.Location = new System.Drawing.Point(461, 82);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(37, 39);
            this.lblEuros.TabIndex = 13;
            this.lblEuros.Text = "€";
            // 
            // lblEntrants
            // 
            this.lblEntrants.AutoSize = true;
            this.lblEntrants.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrants.Location = new System.Drawing.Point(21, 13);
            this.lblEntrants.Name = "lblEntrants";
            this.lblEntrants.Size = new System.Drawing.Size(155, 39);
            this.lblEntrants.TabIndex = 15;
            this.lblEntrants.Text = "Entrants";
            this.lblEntrants.Click += new System.EventHandler(this.lbls_Click);
            // 
            // lblPrimer_Plat
            // 
            this.lblPrimer_Plat.AutoSize = true;
            this.lblPrimer_Plat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimer_Plat.Location = new System.Drawing.Point(203, 13);
            this.lblPrimer_Plat.Name = "lblPrimer_Plat";
            this.lblPrimer_Plat.Size = new System.Drawing.Size(146, 39);
            this.lblPrimer_Plat.TabIndex = 16;
            this.lblPrimer_Plat.Text = "Primers";
            this.lblPrimer_Plat.Click += new System.EventHandler(this.lbls_Click);
            // 
            // lblSegon_Plat
            // 
            this.lblSegon_Plat.AutoSize = true;
            this.lblSegon_Plat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegon_Plat.Location = new System.Drawing.Point(377, 13);
            this.lblSegon_Plat.Name = "lblSegon_Plat";
            this.lblSegon_Plat.Size = new System.Drawing.Size(140, 39);
            this.lblSegon_Plat.TabIndex = 17;
            this.lblSegon_Plat.Text = "Segons";
            this.lblSegon_Plat.Click += new System.EventHandler(this.lbls_Click);
            // 
            // lblPostres
            // 
            this.lblPostres.AutoSize = true;
            this.lblPostres.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostres.Location = new System.Drawing.Point(552, 13);
            this.lblPostres.Name = "lblPostres";
            this.lblPostres.Size = new System.Drawing.Size(143, 39);
            this.lblPostres.TabIndex = 18;
            this.lblPostres.Text = "Postres";
            this.lblPostres.Click += new System.EventHandler(this.lbls_Click);
            // 
            // lblRefresc
            // 
            this.lblRefresc.AutoSize = true;
            this.lblRefresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresc.Location = new System.Drawing.Point(721, 13);
            this.lblRefresc.Name = "lblRefresc";
            this.lblRefresc.Size = new System.Drawing.Size(145, 39);
            this.lblRefresc.TabIndex = 19;
            this.lblRefresc.Text = "Refresc";
            this.lblRefresc.Click += new System.EventHandler(this.lbls_Click);
            // 
            // lblLicors
            // 
            this.lblLicors.AutoSize = true;
            this.lblLicors.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicors.Location = new System.Drawing.Point(111, 70);
            this.lblLicors.Name = "lblLicors";
            this.lblLicors.Size = new System.Drawing.Size(117, 39);
            this.lblLicors.TabIndex = 20;
            this.lblLicors.Text = "Licors";
            this.lblLicors.Click += new System.EventHandler(this.lbls_Click);
            // 
            // lblVi_Blanc
            // 
            this.lblVi_Blanc.AutoSize = true;
            this.lblVi_Blanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVi_Blanc.Location = new System.Drawing.Point(273, 70);
            this.lblVi_Blanc.Name = "lblVi_Blanc";
            this.lblVi_Blanc.Size = new System.Drawing.Size(152, 39);
            this.lblVi_Blanc.TabIndex = 21;
            this.lblVi_Blanc.Text = "Vi Blanc";
            this.lblVi_Blanc.Click += new System.EventHandler(this.lbls_Click);
            // 
            // lblVi_Negre
            // 
            this.lblVi_Negre.AutoSize = true;
            this.lblVi_Negre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVi_Negre.Location = new System.Drawing.Point(655, 70);
            this.lblVi_Negre.Name = "lblVi_Negre";
            this.lblVi_Negre.Size = new System.Drawing.Size(159, 39);
            this.lblVi_Negre.TabIndex = 22;
            this.lblVi_Negre.Text = "Vi Negre";
            this.lblVi_Negre.Click += new System.EventHandler(this.lbls_Click);
            // 
            // lblVi_Rosat
            // 
            this.lblVi_Rosat.AutoSize = true;
            this.lblVi_Rosat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVi_Rosat.Location = new System.Drawing.Point(464, 70);
            this.lblVi_Rosat.Name = "lblVi_Rosat";
            this.lblVi_Rosat.Size = new System.Drawing.Size(156, 39);
            this.lblVi_Rosat.TabIndex = 23;
            this.lblVi_Rosat.Text = "Vi Rosat";
            this.lblVi_Rosat.Click += new System.EventHandler(this.lbls_Click);
            // 
            // pnlOpcions
            // 
            this.pnlOpcions.Controls.Add(this.lblVi_Rosat);
            this.pnlOpcions.Controls.Add(this.lblVi_Negre);
            this.pnlOpcions.Controls.Add(this.lblVi_Blanc);
            this.pnlOpcions.Controls.Add(this.lblLicors);
            this.pnlOpcions.Controls.Add(this.lblRefresc);
            this.pnlOpcions.Controls.Add(this.lblPostres);
            this.pnlOpcions.Controls.Add(this.lblSegon_Plat);
            this.pnlOpcions.Controls.Add(this.lblPrimer_Plat);
            this.pnlOpcions.Controls.Add(this.lblEntrants);
            this.pnlOpcions.Location = new System.Drawing.Point(43, 159);
            this.pnlOpcions.Name = "pnlOpcions";
            this.pnlOpcions.Size = new System.Drawing.Size(896, 120);
            this.pnlOpcions.TabIndex = 14;
            // 
            // clbListProductes
            // 
            this.clbListProductes.BackColor = System.Drawing.Color.Black;
            this.clbListProductes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbListProductes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbListProductes.ForeColor = System.Drawing.Color.White;
            this.clbListProductes.FormattingEnabled = true;
            this.clbListProductes.Location = new System.Drawing.Point(226, 304);
            this.clbListProductes.Name = "clbListProductes";
            this.clbListProductes.Size = new System.Drawing.Size(437, 216);
            this.clbListProductes.TabIndex = 15;
            this.clbListProductes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbListProductes_ItemCheck);
            // 
            // lblbtnEnrere
            // 
            this.lblbtnEnrere.AutoSize = true;
            this.lblbtnEnrere.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnEnrere.Location = new System.Drawing.Point(699, 499);
            this.lblbtnEnrere.Name = "lblbtnEnrere";
            this.lblbtnEnrere.Size = new System.Drawing.Size(101, 31);
            this.lblbtnEnrere.TabIndex = 22;
            this.lblbtnEnrere.Text = "Enrere";
            this.lblbtnEnrere.Click += new System.EventHandler(this.lblbtnEnrere_Click);
            // 
            // lblBtnIntroduir
            // 
            this.lblBtnIntroduir.AutoSize = true;
            this.lblBtnIntroduir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnIntroduir.Location = new System.Drawing.Point(826, 499);
            this.lblBtnIntroduir.Name = "lblBtnIntroduir";
            this.lblBtnIntroduir.Size = new System.Drawing.Size(123, 31);
            this.lblBtnIntroduir.TabIndex = 23;
            this.lblBtnIntroduir.Text = "Introduir";
            this.lblBtnIntroduir.Click += new System.EventHandler(this.lblBtnIntroduir_Click);
            // 
            // pnlLinia
            // 
            this.pnlLinia.BackColor = System.Drawing.Color.White;
            this.pnlLinia.Enabled = false;
            this.pnlLinia.Location = new System.Drawing.Point(264, 58);
            this.pnlLinia.Name = "pnlLinia";
            this.pnlLinia.Size = new System.Drawing.Size(515, 5);
            this.pnlLinia.TabIndex = 10;
            // 
            // pbDisponibilitat
            // 
            this.pbDisponibilitat.Image = ((System.Drawing.Image)(resources.GetObject("pbDisponibilitat.Image")));
            this.pbDisponibilitat.Location = new System.Drawing.Point(799, 7);
            this.pbDisponibilitat.Name = "pbDisponibilitat";
            this.pbDisponibilitat.Size = new System.Drawing.Size(160, 109);
            this.pbDisponibilitat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisponibilitat.TabIndex = 24;
            this.pbDisponibilitat.TabStop = false;
            this.pbDisponibilitat.Click += new System.EventHandler(this.pbDisponibilitat_Click);
            // 
            // pbImatgeMenute
            // 
            this.pbImatgeMenute.Image = global::AplicacioAdministrador.Properties.Resources.ImgMenu;
            this.pbImatgeMenute.Location = new System.Drawing.Point(22, 13);
            this.pbImatgeMenute.Name = "pbImatgeMenute";
            this.pbImatgeMenute.Size = new System.Drawing.Size(216, 130);
            this.pbImatgeMenute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImatgeMenute.TabIndex = 8;
            this.pbImatgeMenute.TabStop = false;
            this.pbImatgeMenute.Click += new System.EventHandler(this.pbImatgeMenute_Click);
            // 
            // frmAltaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(971, 567);
            this.Controls.Add(this.pnlLinia);
            this.Controls.Add(this.pbDisponibilitat);
            this.Controls.Add(this.lblBtnIntroduir);
            this.Controls.Add(this.lblbtnEnrere);
            this.Controls.Add(this.clbListProductes);
            this.Controls.Add(this.pnlOpcions);
            this.Controls.Add(this.lblEuros);
            this.Controls.Add(this.lblPreu);
            this.Controls.Add(this.txbPreu);
            this.Controls.Add(this.txbTitolMenu);
            this.Controls.Add(this.pbImatgeMenute);
            this.Controls.Add(this.lblDescripcioProducte);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaMenu";
            this.Text = "frmAltaMenu";
            this.pnlOpcions.ResumeLayout(false);
            this.pnlOpcions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisponibilitat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImatgeMenute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcioProducte;
        private System.Windows.Forms.PictureBox pbImatgeMenute;
        private System.Windows.Forms.TextBox txbTitolMenu;
        private System.Windows.Forms.TextBox txbPreu;
        private System.Windows.Forms.Label lblPreu;
        private System.Windows.Forms.Label lblEuros;
        private System.Windows.Forms.Label lblEntrants;
        private System.Windows.Forms.Label lblPrimer_Plat;
        private System.Windows.Forms.Label lblSegon_Plat;
        private System.Windows.Forms.Label lblPostres;
        private System.Windows.Forms.Label lblRefresc;
        private System.Windows.Forms.Label lblLicors;
        private System.Windows.Forms.Label lblVi_Blanc;
        private System.Windows.Forms.Label lblVi_Negre;
        private System.Windows.Forms.Label lblVi_Rosat;
        private System.Windows.Forms.Panel pnlOpcions;
        private System.Windows.Forms.CheckedListBox clbListProductes;
        private System.Windows.Forms.Label lblbtnEnrere;
        private System.Windows.Forms.Label lblBtnIntroduir;
        private System.Windows.Forms.PictureBox pbDisponibilitat;
        private System.Windows.Forms.Panel pnlLinia;

    }
}