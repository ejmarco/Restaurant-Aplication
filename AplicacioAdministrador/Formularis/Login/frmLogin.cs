using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacioAdministrador.Nucli;

namespace AplicacioAdministrador.Formularis.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void pbBtnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTancar_Click(object sender, EventArgs e)
        {
            cEngine.setConectarse(false);
            this.Close();
        }

        private void lblBtnLogin_Click(object sender, EventArgs e)
        {
            cEngine.setUsuari(this.txbUsuari.Text);
            cEngine.setPassword(this.txbPassword.Text);
            cEngine.setConectarse(true);
            this.Close();
        }

        private void lblBtnLogin_MouseDown(object sender, MouseEventArgs e)
        {
            this.lblBtnLogin.Location = new Point(this.lblBtnLogin.Location.X + 3, this.lblBtnLogin.Location.Y + 3);
            this.lblBtnLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void lblBtnLogin_MouseUp(object sender, MouseEventArgs e)
        {
            this.lblBtnLogin.Location = new Point(269,134);
            this.lblBtnLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAmagat_Click(object sender, EventArgs e)
        {

        }
        //HAY QUE HACER UN BOTON CLOSE PARA QUE VAYA BIEN
    }
}
