using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacioAdministrador.Formularis.Principal;
using AplicacioAdministrador.Nucli;
using AplicacioAdministrador.Formularis.Modificar;


namespace AplicacioAdministrador.Formularis.Altes
{
    partial class frmAltaProducte : Form
    {
        private int posicioAntiguaX, posicioAntiguaY;
        private Boolean pbImatgeProducteB = false;
        private Boolean pbIconaProducteB = false;
        private String pbImatgeProducteS = "";
        private String pbIconaProducteS = "";
        private cSystem sys = null;
        private frmPrincipal frm = null;
        public frmAltaProducte(cSystem system, frmPrincipal form)
        {
            InitializeComponent();
            this.frm = form;
            this.sys = system;
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

        private void lblbtnEnrere_Click(object sender, EventArgs e)
        {
            frm.ponerForm(new frmModificarProducte(this.sys));
            frm.seleccionarBoto("Producte");
            this.Close();
        }
        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "All files (*.*)|*.*|JPG(*.jpg)|*.jpg |PNG (*.png)|*.png";
            browseFile.Title = "Visualitzar Imatges";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                pb.Image = System.Drawing.Bitmap.FromFile(browseFile.FileName);             

                if (pb.Name.Equals("pbImatgeProducte"))
                {
                    this.pbImatgeProducteB = true;
                    this.pbImatgeProducteS = browseFile.FileName;
                }
                else
                {
                    this.pbIconaProducteB = true;
                    this.pbIconaProducteS = browseFile.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblBtnIntroduir_Click(object sender, EventArgs e)
        {
            if (this.txbNomProducte.Text.Equals(" ") || this.cmbTipusProducte.Text.Equals("") || this.txbPreuProducte.Text.Equals(" ") || this.txbDescripcioProducte.Text.Equals(" ") || this.pbIconaProducteB == false || this.pbImatgeProducteB == false)
            {
                MessageBox.Show("Falten camps per omplir, comprova que hagis introduit tots els camps o insertat les imatges!", "T'has deixat camps per omplir",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String preu = this.txbPreuProducte.Text;
                Boolean entrar = false;
                int i = 0;
                try
                {
                    float numero = float.Parse(preu);
                }
                catch(Exception ex)
                {
                    entrar = true;
                }
                if (preu.Contains(",") || preu.Contains("."))
                {
                    foreach (char c in preu)
                    {
                        if (c == '.' || c == ',')
                        {
                            i++;
                        }
                    }
                }
                if (i > 1 || entrar)
                {
                    MessageBox.Show("El format del preu no es correcte, comprova que hagis introduït nomes una coma o punt o que estigui en format numeric!", "Format del preu incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    preu = preu.Replace(",", ".");
                    cProducte pro = new cProducte(this.txbNomProducte.Text, this.cmbTipusProducte.Text, this.pbIconaProducteS, this.pbImatgeProducteS, preu, this.txbDescripcioProducte.Text);
                    if (sys.insertarProducte(pro))
                    {
                        MessageBox.Show("La operació d'alta producte ha estat satisfactòria!", "Operacio realitzada correctament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sys.uptdate();
                        frm.ponerForm(new frmModificarProducte(this.sys));
                        frm.seleccionarBoto("Producte");
                        this.Close();
                    }
                }
            }
        }
    }
}
