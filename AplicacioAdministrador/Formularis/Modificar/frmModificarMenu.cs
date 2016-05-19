using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacioAdministrador.Nucli;

namespace AplicacioAdministrador.Formularis.Modificar
{
    partial class frmModificarMenu : Form
    {
        private String directori = "";
        const int xB = 99;
        const int yB = 35;
        private int x = xB;//SI SUMAS O RESTAS, LA POSICION DEL OBJETO SE DESPLAZA LATERALMENTE (si restas izquierda, si sumas derecha)
        private int y = yB;//POSICION VERTICAL SI SUMAS PONES EL OBJETO MAS BAJO QUE EL ANTERIOR, SI RESTAS LO ACERCAS
        private cSystem sys = null;
        private String selectedLbl = "";
        private int disponibilitat = 0;
        private Boolean imatgeSeleccionada = false;
        private cMenu menuAModificar = null;
        private String Imatge = "";
        private List<cMenu> coleccioMenus = null;
        private List<cProducte> coleccioProductes = null;
        private List<cProducte> coleccioProductesCheked = new List<cProducte>();
        private List<cProducte> coleccioProductesMenu = new List<cProducte>();

        public frmModificarMenu(cSystem system)
        {
            InitializeComponent();
            this.sys = system;
            this.coleccioMenus = sys.getColeccioMenus();
            this.coleccioProductes = sys.getColeccioProductes();
            this.directori = sys.getDirectori();
        }
        private void frmModificarMenu_Load(object sender, EventArgs e)
        {
            this.pnlTotsElsMenus.Visible = false;
            this.omplirInformacioMenus();
        }
        private void omplirInformacioMenus()
        {
            this.pnlMenuAModificar.Visible = false;
            this.pnlTotsElsMenus.Visible = true;
            this.pnlTotsElsMenus.Enabled = true;
            this.pnlTotsElsMenus.Controls.Clear();
            this.coleccioProductesMenu.Clear();
            this.coleccioMenus = sys.getColeccioMenus();
            this.x = xB;
            this.y = yB;
            this.pnlTotsElsMenus.Location = new System.Drawing.Point(12, 12);
            this.pnlTotsElsMenus.Size = new System.Drawing.Size(942, 543);

            for (int i = 0; i < this.coleccioMenus.Count(); i++)
            {
                #region CrearPictureBox Imatge Menu
                PictureBox pic = new PictureBox();
                #region FileStrem
                System.IO.FileStream fs = new System.IO.FileStream(this.directori + "\\Menus\\" + this.coleccioMenus[i].getIdMenu() + "\\Imatge\\" + this.coleccioMenus[i].getImatgeMenu(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
                pic.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
                #endregion
                pic.Name = "pic" + i;
                pic.Width = 128;
                pic.Height = 128;
                pic.Location = new System.Drawing.Point(this.x, this.y);
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pnlTotsElsMenus.Controls.Add(pic);
                pic.Click += new EventHandler(this.pnl_Click);
                pic.Name = "pic" + i;
                #endregion
                #region CrearPictureBox DELETE
                PictureBox del = new PictureBox();
                del.Name = "del" + i;
                del.Width = 80;
                del.Height = 80;
                del.Location = new System.Drawing.Point(this.x + 700, this.y + 10);
                del.Image = AplicacioAdministrador.Properties.Resources.Garbage;
                del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pnlTotsElsMenus.Controls.Add(del);
                del.Click += new EventHandler(this.eliminar_Click);
                del.Name = "del" + i;
                #endregion
                #region crear visibilitat
                PictureBox vis = new PictureBox();//vis = visibilitat
                vis.Name = "vis" + i;
                vis.Width = 80;
                vis.Height = 80;
                vis.Location = new System.Drawing.Point(this.x + 600, this.y + 10);
                if (Convert.ToInt32(sys.getColeccioMenus()[i].getDisponibilitatMenu()) == 0)
                {
                    vis.Image = AplicacioAdministrador.Properties.Resources.unview;
                }
                else
                {
                    vis.Image = AplicacioAdministrador.Properties.Resources.View;
                }
                vis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pnlTotsElsMenus.Controls.Add(vis);
                vis.Click += new EventHandler(this.vis_Click);
                vis.Name = "vis" + i;
                #endregion
                #region crearLabel
                Label lbl = new Label();
                Label lbl1 = new Label();
                lbl1.Name = "lbl" + i;
                lbl.Name = "lbl" + i;
                lbl.Text = sys.getColeccioMenus()[i].getTitolMenu();
                lbl1.Text = "Preu: " + sys.getColeccioMenus()[i].getPreuMenu() + "€";
                lbl.ForeColor = Color.White;
                lbl.Size = new System.Drawing.Size(500, 31);
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl.Location = new System.Drawing.Point(this.x + 140, this.y + 30);
                lbl1.ForeColor = Color.White;
                lbl1.Size = new System.Drawing.Size(500, 31);
                lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl1.Location = new System.Drawing.Point(this.x + 140, this.y + 60);
                lbl.Click += new EventHandler(this.pnl_Click);
                lbl1.Click += new EventHandler(this.pnl_Click);
                this.pnlTotsElsMenus.Controls.Add(lbl);
                this.pnlTotsElsMenus.Controls.Add(lbl1);
                #endregion
                this.y += pic.Width + 20;
            }
        }
        private void pnl_Click(object sender, EventArgs e)
        {
            int num;
            try
            {
                PictureBox pnl = (PictureBox)sender;
                num = Int32.Parse(pnl.Name.Substring(3).ToString());
            }
            catch (Exception ex)
            {
                Label lbl = (Label)sender;
                num = Int32.Parse(lbl.Name.Substring(3).ToString());
            }

            cMenu menu = sys.getColeccioMenus()[num];
            this.informacioMenu(menu);
        }
        private void informacioMenu(cMenu menu)
        {
            this.menuAModificar = menu;
            this.pnlTotsElsMenus.Enabled = false;
            this.pnlTotsElsMenus.Visible = false;
            this.pnlMenuAModificar.Enabled = true;
            this.pnlMenuAModificar.Visible = true;
            this.pnlMenuAModificar.Location = new System.Drawing.Point(12, 12);
            this.pnlMenuAModificar.Size = new System.Drawing.Size(942, 543);
            #region FileStream Imatge
            System.IO.FileStream fs = new System.IO.FileStream(this.directori + "\\Menus\\" + menu.getIdMenu() + "\\Imatge\\" + menu.getImatgeMenu(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
            this.pbImatgeMenu.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
            #endregion
            this.txbTitolMenu.Text = menu.getTitolMenu();
            if (menu.getDisponibilitatMenu() == "0")
            {
                this.pbDisponibilitat.Image = AplicacioAdministrador.Properties.Resources.unview;
                this.disponibilitat = 0;
            }
            else
            {
                this.pbDisponibilitat.Image = AplicacioAdministrador.Properties.Resources.View;
                this.disponibilitat = 1;
            }
            this.Imatge = this.directori + "\\Menus\\" + menu.getIdMenu() + "\\Imatge\\" + menu.getImatgeMenu();
            this.txbPreu.Text = menu.getPreuMenu();
            this.coleccioProductesMenu = menu.getColeccioProductes();
        }
        private void vis_Click(object sender, EventArgs e)
        {
            int num;

            PictureBox vis = (PictureBox)sender;
            num = Int32.Parse(vis.Name.Substring(3).ToString());
            if (Convert.ToInt32(sys.getColeccioMenus()[num].getDisponibilitatMenu()) == 0)
            {
                vis.Image = AplicacioAdministrador.Properties.Resources.View;
                sys.getColeccioMenus()[num].setDisponibilitatMenu("1");
                sys.cambiarVisibilitat(sys.getColeccioMenus()[num].getIdMenu(), "1");
                this.disponibilitat = 1;
            }
            else
            {
                vis.Image = AplicacioAdministrador.Properties.Resources.unview;
                sys.getColeccioMenus()[num].setDisponibilitatMenu("0");
                sys.cambiarVisibilitat(sys.getColeccioMenus()[num].getIdMenu(), "0");
                this.disponibilitat = 0;
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
        private void pbImatgeMenu_Click(object sender, EventArgs e)
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
                this.imatgeSeleccionada = true;
                this.Imatge = browseFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
        }
        private void eliminar_Click(object sender, EventArgs e)
        {
            int num;
            PictureBox del = (PictureBox)sender;
            num = Int32.Parse(del.Name.Substring(3).ToString());
            var result = MessageBox.Show("Estas segur de que vols eliminar el producte " + sys.getColeccioMenus()[num].getTitolMenu() + "? Si confirmes no es podrà tornar enrere!", "Segur que desitga eliminar aques producte?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                if (sys.eliminarMenu(sys.getColeccioMenus()[num].getIdMenu()))
                {
                    MessageBox.Show("Producte eliminat correctament!", "Operació Satisfactòria",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.coleccioMenus.Remove(sys.getColeccioMenus()[num]);
                    this.omplirInformacioMenus();
                }
                else
                {
                    MessageBox.Show("Per Raons que desconeixem no hem pogut eliminar el producte " + sys.getColeccioMenus()[num].getTitolMenu() + " preguem disculpin les molesties", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            foreach (cProducte pro in this.coleccioProductes)
            {
                if (pro.getTipusProducte().Equals(tipusProducte))
                {
                    String producte = pro.getNomProducte();
                    producte += "  " + pro.getPreuProducte() + "€";
                    this.coleccioProductesCheked.Add(pro);
                    this.clbListProductes.Items.Add(producte);

                    foreach (cProducte pro2 in this.coleccioProductesMenu)
                    {
                        if (pro.getIdProducte() == pro2.getIdProducte())
                        {
                            this.clbListProductes.SetItemChecked(this.clbListProductes.Items.Count - 1, true);
                        }
                    }
                }
            }
            this.clbListProductes.Visible = true;
        }
        private void clbListProductes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            try
            {
                if (clb.GetItemCheckState(clb.SelectedIndex) == 0)
                {
                    this.coleccioProductesMenu.Add(this.coleccioProductesCheked[clb.SelectedIndex]);
                }
                else
                {
                    foreach (cProducte pro in this.coleccioProductesMenu)
                    {
                        if (pro.getIdProducte() == this.coleccioProductesCheked[clb.SelectedIndex].getIdProducte())
                        {
                            this.coleccioProductesMenu.Remove(pro);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void lblBtnIntroduir_Click(object sender, EventArgs e)
        {
            if (this.txbTitolMenu.Text.Equals(this.menuAModificar.getTitolMenu()) && this.txbPreu.Text.Equals(this.menuAModificar.getPreuMenu()) && this.imatgeSeleccionada == false && this.disponibilitat == Int32.Parse(menuAModificar.getDisponibilitatMenu()) || this.coleccioProductesMenu.Count == 0 || this.txbPreu.Text.Equals("") || this.txbTitolMenu.Text.Equals(""))
            {
                MessageBox.Show("Falten camps per omplir, comprova que hagis introduit tots els camps o insertat les imatges!", "T'has deixat camps per omplir", MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
            else
            {
                String preu = this.txbPreu.Text;
                Boolean entrar = false;
                int i = 0;
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
                    cMenu menu = new cMenu(this.txbTitolMenu.Text, preu, this.disponibilitat.ToString(), this.Imatge, this.coleccioProductesMenu);
                    if (sys.modificarMenu(this.menuAModificar.getIdMenu(), menu))
                    {
                        MessageBox.Show("La operació de modificació del menu ha estat satisfactòria!","Operacio realitzada correctament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sys.uptdate();
                        this.buidarInformacioMenu();
                        this.omplirInformacioMenus();
                    }
                    else
                    {
                        MessageBox.Show("Per motius externs al nostre sistema no hem pogut realitzar l'operació de modificació del menú, preguem disculpin les molesties", "No s'ha pogut realitzar l'operacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.buidarInformacioMenu();
                        this.omplirInformacioMenus();
                    }
                }
            }
        }
        private void lblbtnEnrere_Click(object sender, EventArgs e)
        {
            this.buidarInformacioMenu();
            this.omplirInformacioMenus();
        }
        private void buidarInformacioMenu()
        {
            this.lblEntrants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrimer_Plat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSegon_Plat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRefresc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPostres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLicors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVi_Blanc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVi_Negre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVi_Rosat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbListProductes.Visible = false;
        }
    }
}