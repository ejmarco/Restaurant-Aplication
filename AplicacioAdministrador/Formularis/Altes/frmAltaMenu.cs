using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacioAdministrador.Nucli;
using AplicacioAdministrador.Formularis.Principal;
using AplicacioAdministrador.Formularis.Modificar;

namespace AplicacioAdministrador.Formularis.Altes
{
 partial class frmAltaMenu : Form
    {
        private cSystem sys = null;
        private String selectedLbl = "";
        private List<cProducte> coleccioProductes = null;
        private List<cProducte> coleccioProductesCheked = new List<cProducte>();
        private List<cProducte> coleccioProductesSeleccionats = new List<cProducte>();
        private Boolean imatgeSeleccionada = false;
        private Int32 disponibilitat = 0;
        private String pbImatgeMenuS = "";
     private frmPrincipal frm = null;   
        public frmAltaMenu(cSystem system,frmPrincipal frm)
        {
            InitializeComponent();
            this.sys = system;
            this.coleccioProductes = sys.getColeccioProductes();
            this.frm = frm;
        }

        private void lbls_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            this.lblEntrants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrimer_Plat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSegon_Plat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRefresc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPostres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLicors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVi_Blanc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVi_Negre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVi_Rosat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.omplirChequedListBox(lbl.Name);
        }
        private void omplirChequedListBox(String tipusProducte)
        {
            if (tipusProducte.Contains("_"))
            {
                tipusProducte = tipusProducte.Replace("_", " ");
            }
            tipusProducte = tipusProducte.Replace("lbl", "");
            this.selectedLbl = tipusProducte;
            this.clbListProductes.Items.Clear();
            this.coleccioProductesCheked.Clear();
            foreach(cProducte pro in this.coleccioProductes)
            {
                if(pro.getTipusProducte().Equals(tipusProducte))
                {
                    String producte = pro.getNomProducte();
                    producte += "    \t" + pro.getPreuProducte() + "€";
                    this.coleccioProductesCheked.Add(pro);
                    this.clbListProductes.Items.Add(producte);
                    foreach (cProducte pro2 in this.coleccioProductesSeleccionats)
                    {
                        if (pro2.getIdProducte() == pro.getIdProducte())
                        {
                            this.clbListProductes.SetItemChecked(this.clbListProductes.Items.Count - 1, true);
                        }
                    }
                }
            }
        }

        private void clbListProductes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            try
            {
                if (clb.GetItemCheckState(clb.SelectedIndex) == 0)
                {
                    this.coleccioProductesSeleccionats.Add(this.coleccioProductesCheked[clb.SelectedIndex]);
                }
                else
                {
                    this.coleccioProductesSeleccionats.Remove(this.coleccioProductesCheked[clb.SelectedIndex]);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void pbImatgeMenute_Click(object sender, EventArgs e)
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
                pbImatgeMenuS = browseFile.FileName;
                this.imatgeSeleccionada = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblBtnIntroduir_Click(object sender, EventArgs e)
        {
            if (this.txbTitolMenu.Text.Equals("") || this.txbTitolMenu.Text.Equals("Titol Menu") || this.txbPreu.Text.Equals("0") || this.coleccioProductesSeleccionats.Count() == 0 || this.imatgeSeleccionada == false)
            {
                MessageBox.Show("Falten camps per omplir, comprova que hagis introduit tots els camps o insertat les imatges!", "T'has deixat camps per omplir",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String preu = this.txbPreu.Text;
                int i = 0;
                Boolean entrar = false;
                try
                {
                    float numero = float.Parse(preu);
                }
                catch (Exception ex)
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
                    cMenu menu = new cMenu(this.txbTitolMenu.Text, preu, this.disponibilitat.ToString(), this.pbImatgeMenuS, this.coleccioProductesSeleccionats);
                    if (sys.insertarMenu(menu))
                    {
                        MessageBox.Show("La operació d'alta de menu ha estat satisfactòria!", "Operacio realitzada correctament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sys.uptdate();
                        frm.ponerForm(new frmModificarMenu(this.sys));
                        frm.seleccionarBoto("Menu");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Per motius externs al nostre sistema no hem pogut realitzar l'operació de d'alta menú, preguem disculpin les molesties", "No s'ha pogut realitzar l'operacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        frm.ponerForm(new frmModificarMenu(this.sys));
                        this.Close();
                    }
                }
            }
        }

        private void pbDisponibilitat_Click(object sender, EventArgs e)
        {
            if (this.disponibilitat == 1)
            {
                this.disponibilitat = 0;
                this.pbDisponibilitat.Image = AplicacioAdministrador.Properties.Resources.unview;
            }
            else
            {
                this.disponibilitat = 1;
                this.pbDisponibilitat.Image = AplicacioAdministrador.Properties.Resources.View;
            }
        }

        private void lblbtnEnrere_Click(object sender, EventArgs e)
        {
            frm.ponerForm(new frmModificarMenu(this.sys));
            frm.seleccionarBoto("Menu");
        }
    }
}
