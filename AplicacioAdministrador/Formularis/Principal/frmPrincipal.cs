using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacioAdministrador.Nucli;
using AplicacioAdministrador.Formularis.Altes;
using AplicacioAdministrador.Formularis.Modificar;

namespace AplicacioAdministrador.Formularis.Principal
{
    public partial class frmPrincipal : Form
    {
        //COMPROVAR LOS PRECIOS LO DE LA COMA Y PONER QUE NO SE PUEDAN INTRODUCIR VALORES MENORES QUE 0
        private int posicioAntiguaX, posicioAntiguaY;
        private static String nomAdministrador;
        private cSystem sys = null;
        public frmPrincipal(String nomAdministrador)
        {
            InitializeComponent();
            this.lblNom.Text = nomAdministrador;
            frmPrincipal.nomAdministrador = nomAdministrador;
            this.IsMdiContainer = true;            
        }

        private void pbBtnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void ponerForm(Form formulario)
        {
            this.pnlPrincipal.Controls.Clear();
            formulario.TopLevel = false;
            formulario.Parent = this.pnlPrincipal;
            formulario.Show();
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            this.posicioAntiguaX = lbl.Location.X;
            this.posicioAntiguaY = lbl.Location.Y;
            lbl.Location = new Point(lbl.Location.X + 3, lbl.Location.Y + 3);
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Location = new Point(this.posicioAntiguaX, this.posicioAntiguaY);
        }

        private void lblAltaProducte_Click(object sender, EventArgs e)
        {
            this.treureBorder();
            this.lblAltaProducte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ponerForm(new frmAltaProducte(this.sys,this));
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.Black;
                }
            }
            sys = new cSystem();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            cEngine.setConectarse(false);
        }

        private void lblAltaMenu_Click(object sender, EventArgs e)
        {
            this.treureBorder();
            this.lblAltaMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ponerForm(new frmAltaMenu(this.sys,this));
        }

        private void lblModificarProducte_Click(object sender, EventArgs e)
        {
            this.treureBorder();
            this.lblModificarProducte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ponerForm(new frmModificarProducte(this.sys));
        }

        private void lblModificarMenu_Click(object sender, EventArgs e)
        {
            this.treureBorder();
            this.lblModificarMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ponerForm(new frmModificarMenu(this.sys));
        }
        private void treureBorder()
        {
            this.lblAltaProducte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblModificarProducte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAltaMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblModificarMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        public void seleccionarBoto(String boto)
        {
            this.treureBorder();
            if (boto.Equals("Menu"))
            {
                this.lblModificarMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                this.lblModificarProducte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }
    }
}
