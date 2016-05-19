using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacioAdministrador.Nucli;
using System.IO;

namespace AplicacioAdministrador.Formularis.Modificar
{
    partial class frmModificarProducte : Form
    {
        const int xB = 73;
        const int yB = 85;
        private String anteriorSeleccioCmb = "Tots els productes";
        private String directori = "";
        private String IconaS = "";
        private String ImatgeS = "";
        private Boolean cmbActiu = true;
        private cProducte producteAModificar = null;
        private int x = xB;//SI SUMAS O RESTAS, LA POSICION DEL OBJETO SE DESPLAZA LATERALMENTE (si restas izquierda, si sumas derecha)
        private int y = yB;//POSICION VERTICAL SI SUMAS PONES EL OBJETO MAS BAJO QUE EL ANTERIOR, SI RESTAS LO ACERCAS
        private cSystem sys = null;
        public frmModificarProducte(cSystem system)
        {
            InitializeComponent();
            this.sys = system;
            this.directori = sys.getDirectori();
        }
        //Hacer un control de tipos de productos, todos, entrantes, primeros, segundos..
        private void frmModificarProducte_Load(object sender, EventArgs e)
        {
            this.pnlInformacioProducte.Visible = false;
            this.pnlTotsElsProductes.Visible = false;
            this.omplirInformacioProductes("Tots els productes");
        }
        private void omplirInformacioProductes(String tipusProducte)
        {
            this.cmbActiu = true;
            this.pnlInformacioProducte.Visible = false;
            this.pnlTotsElsProductes.Visible = true;
            this.pnlTotsElsProductes.Enabled = true;
            this.pnlTotsElsProductes.Controls.Clear();
            this.x = xB;
            this.y = yB;
            this.pnlTotsElsProductes.Location = new System.Drawing.Point(12, 12);
            Label lblOrdenar = new Label();
            lblOrdenar.Location = new System.Drawing.Point(469 , 13);
            lblOrdenar.Size = new System.Drawing.Size(180, 50);
            lblOrdenar.Text = "Ordenar Per: ";
            lblOrdenar.Font =  new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ComboBox cmbOpcions = new ComboBox();
            cmbOpcions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbOpcions.Size = new System.Drawing.Size(200, 21);
            cmbOpcions.Location = new System.Drawing.Point(649 , 15);
            cmbOpcions.Items.AddRange(new object[] {
            "Tots els productes",
            "Entrants",
            "Primer Plat",
            "Segon Plat",
            "Postres",
            "Refresc",
            "Licor",
            "Vi Blanc",
            "Vi Negre",
            "Vi Rosat"});
            cmbOpcions.Text = this.anteriorSeleccioCmb;
            cmbOpcions.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            this.pnlTotsElsProductes.Controls.Add(lblOrdenar);
            this.pnlTotsElsProductes.Controls.Add(cmbOpcions);
            for (int i = 0; i < sys.getColeccioProductes().Count(); i++)
            {
                if (tipusProducte == "Tots els productes" || tipusProducte == sys.getColeccioProductes()[i].getTipusProducte())
                {
                    #region CrearPictureBox
                        PictureBox pic = new PictureBox();
                        #region FileStrem
                        System.IO.FileStream fs = new System.IO.FileStream(directori + "\\Productes\\" + sys.getColeccioProductes()[i].getIdProducte() + "\\Icona\\" + sys.getColeccioProductes()[i].getIconaProducte(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        pic.Image = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        #endregion
                        pic.Name = "pic" + i;
                        pic.Width = 128;
                        pic.Height = 128;
                        pic.Location = new System.Drawing.Point(this.x, this.y);
                        pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        this.pnlTotsElsProductes.Controls.Add(pic);
                        pic.Click += new EventHandler(this.pnl_Click);
                        pic.Name = "pic" + i;
                    #endregion
                    #region crearLabel
                    Label lbl = new Label();
                    Label lbl1 = new Label();
                    lbl1.Name = "lbl" + i;
                    lbl.Name = "lbl" + i;
                    lbl.Text = sys.getColeccioProductes()[i].getNomProducte();
                    lbl1.Text = "Preu: " + sys.getColeccioProductes()[i].getPreuProducte() + "€";
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
                    this.pnlTotsElsProductes.Controls.Add(lbl);
                    this.pnlTotsElsProductes.Controls.Add(lbl1);
                    #endregion
                    #region pictureBox Eliminar
                        PictureBox pbe = new PictureBox();
                        pbe.Name = "pbe" + i;
                        pbe.Width = 80;
                        pbe.Height = 80;
                        pbe.Location = new System.Drawing.Point(this.x + 650, this.y + 10);
                        pbe.Image = AplicacioAdministrador.Properties.Resources.Garbage;
                        pbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        this.pnlTotsElsProductes.Controls.Add(pbe);
                        pbe.Click += new EventHandler(this.eliminar_Click);
                        pbe.Name = "pbe" + i;
                    #endregion
                    this.y += pic.Width + 20;
                }
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
            
                cProducte pro = sys.getColeccioProductes()[num];
                this.informacioProducte(pro);
        }
        private void informacioProducte(cProducte pro)
        {
            String directoriImatge = this.directori + "\\Productes\\" + pro.getIdProducte() + "\\Imatge\\" + pro.getImatgeProducte();
            String directoriIcona = this.directori + "\\Productes\\" + pro.getIdProducte() + "\\Icona\\" + pro.getIconaProducte();
            this.producteAModificar = pro;
            this.cmbActiu = false;
            this.ImatgeS = directoriImatge;
            this.IconaS = directoriIcona;
            this.pnlTotsElsProductes.Enabled = false;
            this.pnlTotsElsProductes.Visible = false;
            this.pnlInformacioProducte.Visible = true;
            this.pnlInformacioProducte.Enabled = true;
            this.pnlInformacioProducte.Location = new System.Drawing.Point(12, 12);
            #region FileStream ICONA
            System.IO.FileStream fs = new System.IO.FileStream(directoriIcona, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            this.pbIcona.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
            #endregion
            #region FileStream Imatge
            System.IO.FileStream fs1 = new System.IO.FileStream(directoriImatge, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            this.pbImatge.Image = System.Drawing.Image.FromStream(fs1);
            fs1.Close();
            #endregion
            this.txbNomProducte.Text = pro.getNomProducte();
            this.cmbTipusProducte.Text = pro.getTipusProducte();
            this.txbPreuProducte.Text = pro.getPreuProducte();
            this.txbDescripcioProducte.Text = pro.getDescripcioProducte();
        }

        private void lblbtnEnrere_Click(object sender, EventArgs e)
        {
            this.anteriorSeleccioCmb = "Tots els productes";
            this.omplirInformacioProductes("Tots els productes");
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbActiu)
            {
                ComboBox cmb = (ComboBox)sender;
                this.anteriorSeleccioCmb = cmb.Text;
                this.omplirInformacioProductes(cmb.Text);
            }            
        }

        private void lblBtnIntroduir_Click(object sender, EventArgs e)
        {
            String preu = this.txbPreuProducte.Text;
            Boolean entrar = false;
            int i = 0;
            if (this.txbDescripcioProducte.Equals("") || this.txbPreuProducte.Text.Equals("") || this.txbNomProducte.Text.Equals(""))
            {
                MessageBox.Show("Falten camps per omplir, comprova que hagis introduit tots els camps o insertat les imatges!", "T'has deixat camps per omplir", MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
            else
            {
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
                    cProducte pro = new cProducte(this.txbNomProducte.Text, this.cmbTipusProducte.Text, this.IconaS, this.ImatgeS, preu, this.txbDescripcioProducte.Text);
                    if (this.sys.modificarProducte(this.producteAModificar.getIdProducte(), pro))
                    {
                        MessageBox.Show("La operació de modificació del producte ha estat satisfactòria!", "Operacio realitzada correctament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Per raons que desconeixem no hem pogut modificar el producte, preguem disculpin les molesties", "No hem pogut realitzar l'operació", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.cmbActiu = true;
                    this.anteriorSeleccioCmb = "Tots els productes";
                    sys.uptdate();
                    this.omplirInformacioProductes("Tots els productes");
                }
            }
        }

        private void pbImatge_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "All files (*.*)|*.*|JPG(*.jpg)|*.jpg |PNG (*.png)|*.png";
            browseFile.Title = "Visualitzar Imatges";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                this.pbImatge.Image = System.Drawing.Bitmap.FromFile(browseFile.FileName);
                this.ImatgeS = browseFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pbIcona_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "All files (*.*)|*.*|JPG(*.jpg)|*.jpg |PNG (*.png)|*.png";
            browseFile.Title = "Visualitzar Imatges";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                this.pbIcona.Image = System.Drawing.Bitmap.FromFile(browseFile.FileName);
                this.IconaS = browseFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void eliminar_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Int32 numPosicioProducte = Int32.Parse(pb.Name.Substring(3).ToString());
            var result = MessageBox.Show("Estas segur de que vols eliminar el producte " + sys.getColeccioProductes()[numPosicioProducte].getNomProducte() + "? Si confirmes no es podrà tornar enrere!", "Segur que desitga eliminar aques producte?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                if (sys.eliminarProducte(sys.getColeccioProductes()[numPosicioProducte].getIdProducte()))
                {
                    sys.getColeccioProductes().Remove(sys.getColeccioProductes()[numPosicioProducte]);
                    this.omplirInformacioProductes(this.anteriorSeleccioCmb);
                    sys.uptdate();
                }             
            }
        }
    }
}
