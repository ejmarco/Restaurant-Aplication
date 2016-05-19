using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace AplicacioAdministrador.Nucli
{
    class cMySql
    {
        private MySqlConnection conn;
        private String directori = "C:\\Users\\Erikkk\\Dropbox\\Sintesi\\imatgesBDD"; //Directori on es montaran les carpetes de menu i productes
        private String imatgePerDefecte = "C:\\Users\\Erikkk\\Dropbox\\Sintesi\\imatgesBDD\\fcb.png"; //Directori de la imatge per defecte
        private String nomImatgePerDefecte = "fcb.png";//Nom de la imatge per defecte
        public cMySql()
        {
            this.connectar();
        }
        private void connectar()
        {
            if (conn != null)
                conn.Close();

            string connStr = String.Format("server=localhost;user id=root; password=password; database=restaurant; pooling=false");
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error connecting to the server: " + ex.Message);
            }
        }
        public String tipusUsuari(String usuari, String password)
        {
            int usuaris = 0;
            String tipusUsuari = "";
            try
            {
                String sentencia = "SELECT categoriausuari FROM usuari WHERE nomusuari='" + usuari + "' and CONTRASENYAUSUARI='" + password + "';";
                MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() != false)
                {
                    usuaris++;
                }
                if (usuaris == 1)//ha encontrado a alguien
                {
                    tipusUsuari = reader.GetString(0);
                    reader.Close();
                }
                else
                {
                    tipusUsuari = "error";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            return tipusUsuari;
        }
        public String nomUsuari(String usuari, String password)
        {
            String nomDeUsuari = "";

            String sentencia = "select concat(UPPER(LEFT(NOMUSUARI,1)),SUBSTR(NOMUSUARI,2), ' ',UPPER(LEFT(COGNOMUSUARI,1)),'.') AS nom from usuari WHERE NOMUSUARI ='" + usuari + "' and CONTRASENYAUSUARI='" + password + "';";
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nomDeUsuari = reader.GetString(0);
            }
            reader.Close();
            return nomDeUsuari;
        }

        public List<cProducte> omplirColeccioProductes()
        {
            List<cProducte> coleccioProductes = new List<cProducte>();
            #region Sentencia
                String sentencia = "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Entrants' " +
                                   "order by p.nomproducte ASC) " +
                                   "UNION " +
                                   "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Primer Plat' " +
                                   "order by p.nomproducte ASC) " +
                                   "UNION " +
                                   "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Segon Plat' " +
                                   "order by p.nomproducte ASC) " +
                                   "UNION " +
                                   "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Postres' " +
                                   "order by p.nomproducte ASC) " +
                                   "UNION " +
                                   "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Refresc' " +
                                   "order by p.nomproducte ASC) " +
                                   "UNION " +
                                   "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Vi Blanc' " +
                                   "order by p.nomproducte ASC) " +
                                   "UNION " +
                                   "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Vi Negre' " +
                                   "order by p.nomproducte ASC) " +
                                   "UNION " +
                                   "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Vi Rosat' " +
                                   "order by p.nomproducte ASC) " +
                                   "UNION " +
                                   "(SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.textdescripcio as descripcio " +
                                   "from producte p,descripcio d " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.tipusproducte = 'Licor' " + 
                                   "order by p.nomproducte ASC) " ;
            #endregion
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String id,nom, tipus, preu,icona,imatge, descripcio = "";
                id = reader["id"].ToString();
                nom = reader["nom"].ToString();
                tipus = reader["tipus"].ToString();
                #region tractarIcona
                   icona =  this.llegirImatgeProductes(id, "Icona", reader["icona"].ToString());                    
                #endregion
                #region tractarImatge
                   imatge = this.llegirImatgeProductes(id, "Imatge", reader["foto"].ToString());
                #endregion                
                preu = reader["preu"].ToString();
                descripcio = reader["descripcio"].ToString();
                cProducte p = new cProducte(id, nom, tipus, icona, imatge, preu, descripcio);
                coleccioProductes.Add(p);
            }
            reader.Close();
            return coleccioProductes;
        }
        public List<cProducte> omplirColeccioProductes(String idProducte)
        {
            byte[] aByte;
            List<cProducte> coleccioProductes = new List<cProducte>();
            String sentencia = "SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.iddescripcio as descripcio " +
                               "from producte p,descripcio d " +
                               "where p.idProducte = d.idProducte";
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String id, nom, tipus, preu, descripcio = "";
                String icona = "", imatge = "";
                id = reader["id"].ToString();
                nom = reader["nom"].ToString();
                tipus = reader["tipus"].ToString();
                #region tractarIcona
                    icona = this.llegirImatgeProductes(id, "Icona", reader["icona"].ToString());
                #endregion
                #region tractarImatge
                    imatge = this.llegirImatgeProductes(id, "Imatge", reader["foto"].ToString());
                #endregion 
                preu = reader["preu"].ToString();
                descripcio = reader["descripcio"].ToString();
                cProducte p = new cProducte(id, nom, tipus, icona, imatge, preu, descripcio);
                coleccioProductes.Add(p);
            }
            reader.Close();
            return coleccioProductes;
        }
        public List<cMenu> omplirColeccioMenus()
        {
            List<cMenu> coleccioMenus = new List<cMenu>();
            String sentencia = "SELECT idmenu as id, titolmenu as titol, preumenu as preu, disponibilitatmenu as disponibilitat, imatgemenu as img " +
                               "FROM menu m " + 
                               "Order BY titolmenu ASC";
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String id, titol, preu, disponibilitat;
                String imatge = null;
                id = reader["id"].ToString();
                titol = reader["titol"].ToString();
                preu = reader["preu"].ToString();
                disponibilitat = reader["disponibilitat"].ToString();
                #region tractarImatge
                    imatge = this.llegirImatgeMenu(id, reader["img"].ToString());
                #endregion                
                cMenu m = new cMenu(id, titol, preu, disponibilitat, imatge);
                coleccioMenus.Add(m);
            }
            reader.Close();
            coleccioMenus = this.omplirProductesAMenus(coleccioMenus);
            return coleccioMenus;
        }
        public String insertarMenu(cMenu menu)
        {
            String idMenu = "";
            String imatgeMenu = this.nomImatgePath(menu.getImatgeMenu());
            String sentencia = "insert into menu (TitolMenu,PreuMenu,DisponibilitatMenu,imatgemenu) VALUES ('" + menu.getTitolMenu() + "'," + menu.getPreuMenu() + "," + menu.getDisponibilitatMenu() + ",'" + imatgeMenu + "');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
                cmd.ExecuteNonQuery();
                idMenu = this.saberUltimaId("menu");
                foreach(cProducte pro in menu.getColeccioProductes())
                {
                    String sentencia3 = "insert into ProductesFormaMenu (idProducte,idMenu) VALUES (" + pro.getIdProducte() + "," + idMenu + ");";
                    MySqlCommand cmd2 = new MySqlCommand(sentencia3, this.conn);
                    cmd2.ExecuteNonQuery();
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                idMenu = "";
            }
            return idMenu;
        }
        public String insertarProducte(cProducte pro)
        {
            String idproducte = "";
            String Icona = this.nomImatgePath(pro.getIconaProducte());
            String Imatge = this.nomImatgePath(pro.getImatgeProducte());
            String sentencia = "insert into producte (nomproducte,tipusproducte,iconaproducte,fotoproducte,preuproducte) values ('" + pro.getNomProducte() + "','"+ pro.getTipusProducte()+"','" + Icona + "','" + Imatge + "','" + pro.getPreuProducte() + "')";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
                cmd.ExecuteNonQuery();
                idproducte = this.saberUltimaId("producte");
                String sentencia3 = "insert into Descripcio (IdProducte,IdiomaDescripcio,TextDescripcio) VALUES (" + idproducte + ", 0 ,'" + pro.getDescripcioProducte() + "');";
                MySqlCommand cmd2 = new MySqlCommand(sentencia3, this.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                idproducte = "";
            }
            return idproducte;
        }
        public Boolean modificarProducte(String idProducteAModifcar, cProducte proModificat)
        {
            Boolean retorn = true;
            String icona = this.nomImatgePath(proModificat.getIconaProducte());
            String imatge = this.nomImatgePath(proModificat.getImatgeProducte());
            String sentencia = "update producte set nomProducte = '" + proModificat.getNomProducte() + "', tipusproducte = '" + proModificat.getTipusProducte() + "', iconaproducte = '" + icona + "' , fotoproducte = '" + imatge + "' , preuproducte = '" + proModificat.getPreuProducte() + "'  where idproducte = " + idProducteAModifcar + " ";
            String sentencia2 = "update descripcio set textdescripcio = '" + proModificat.getDescripcioProducte() + "' " +
                                "where descripcio.iddescripcio=( " + 
                                    "select descripcio.iddescripcio " +
                                    "from producte " + 
                                    "where producte.idproducte = descripcio.idproducte " +
                                    "and producte.idproducte = "+idProducteAModifcar+" )";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand(sentencia2, this.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                retorn = false;
            }
            return retorn;
        }
        public Boolean modificarMenu(String idMenuAModificar, cMenu menuModificat)
        {
            String Imatge = this.nomImatgePath(menuModificat.getImatgeMenu()); ;
            Boolean retorn = true;
            String sentencia = "update menu set titolmenu = '" + menuModificat.getTitolMenu() + "', preumenu = '" + menuModificat.getPreuMenu() + "', imatgemenu = '" + Imatge + "' , disponibilitatmenu = '" + menuModificat.getDisponibilitatMenu() + "'  where idmenu = " + idMenuAModificar + " ";
            String sentencia2 = "delete productesformamenu from productesformamenu where idmenu = " + idMenuAModificar;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand(sentencia2, this.conn);
                cmd2.ExecuteNonQuery();
                foreach (cProducte pro in menuModificat.getColeccioProductes())
                {
                    String sentencia3 = "insert into ProductesFormaMenu (idProducte,idMenu) VALUES (" + pro.getIdProducte() + "," + idMenuAModificar + ");";
                    MySqlCommand cmd3 = new MySqlCommand(sentencia3, this.conn);
                    cmd3.ExecuteNonQuery();
                }  
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                retorn = false;
            }
            return retorn;
        }
        public Boolean eliminarProducte(String idProducte)
        {
            Boolean retorn = true;
            if (this.comprovarSiProducteFormaMenu(idProducte))
            {
                String sentencia3 = "delete comentari from comentari where idproducte = " +idProducte;
                String sentencia = "DELETE producte " +
                                   "FROM producte " +
                                   "where idproducte = " + idProducte;
                String sentencia2 = "DELETE descripcio " +
                                    "FROM descripcio " +
                                    "where idproducte = " + idProducte;
                MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
                MySqlCommand cmd2 = new MySqlCommand(sentencia2, this.conn);
                MySqlCommand cmd3 = new MySqlCommand(sentencia3, this.conn);
                try
                {
                    cmd3.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    retorn = false;
                }
            }
            else
            {
                retorn = false;
            }
            return retorn;
        }
        public Boolean eliminarMenu(String idMenu)
        {
            Boolean retorn = true;

            String sentencia = "Delete menu from menu where idmenu = " + idMenu; ;
            String sentencia2 = "delete productesformamenu from productesformamenu where idmenu = " + idMenu;
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlCommand cmd2 = new MySqlCommand(sentencia2, this.conn);
            try
            {
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                retorn = false;
            }
            
            return retorn;
        }
        public Boolean eliminarMenuSenseProducte(String titolmenu)
        {
            Boolean retorn = true;
            String idMenu = "";
            String sentencia3 = "Select idmenu as id from menu where titolmenu = '" + titolmenu + "'";
            String sentencia = "Delete menu from menu where titolmenu = '" + titolmenu + "'";
            String sentencia2 = "delete pfm from productesformamenu pfm , menu m where m.idmenu = pfm.idmenu and m.titolmenu = '" + titolmenu + "'";
            String sentencia4 = "delete c.* from comentari c, menu m " +
                                "where c.idmenu = m.idmenu " +
                                "and m.titolmenu = '" + titolmenu + "'";
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlCommand cmd2 = new MySqlCommand(sentencia2, this.conn);
            MySqlCommand cmd3 = new MySqlCommand(sentencia3, this.conn);
            MySqlCommand cmd4 = new MySqlCommand(sentencia4, this.conn);
            
            try
            {
                MySqlDataReader reader = cmd3.ExecuteReader();
                while (reader.Read())
                {
                    idMenu = reader["id"].ToString();
                }
                reader.Close();
                this.eliminarCarpetaMenu(idMenu);
                cmd4.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                retorn = false;
            }

            return retorn;
        }
        public Boolean cambiarVisibilitat(String idMenu, String visibilitat)
        {
            Boolean retorn = true;
            String sentencia = "update menu set disponibilitatmenu = '" + visibilitat + "'  where idmenu = '" + idMenu + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                retorn = false;
            }
            return retorn;
        }
        private Boolean comprovarSiProducteFormaMenu(String idProducte)
        {
            Boolean retorn = true;
            int numeroDeMenus = 0;
            int menusAEliminar = 0;
            String menus = "";
            String menusEliminar = "";
            String sentencia = "SELECT m.titolmenu as titol , COUNT(*) as numeroproductes " +
                               "FROM productesformamenu p , menu m " +
                               "where m.idmenu = p.idmenu " +
                               "and m.idmenu in " +
                                    "(Select m.idmenu " +
                                    "from menu m, producte p, productesformamenu pfm " +
                                    "where pfm.idmenu = m.idmenu " +
                                    "and pfm.idproducte = p.idproducte " +
                                    "and p.idproducte = " + idProducte + ") " +
                                "group by titolmenu";
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
             {
                 if (reader["titol"].ToString() != null || reader["titol"].ToString() != "")
                 {
                     if (numeroDeMenus == 0)
                     {
                         if (reader["numeroproductes"].ToString().Equals("1"))
                         {
                             if (menusAEliminar == 0)
                             {
                                 menusEliminar = reader["titol"].ToString();
                             }
                             else
                             {
                                 menusEliminar = menusEliminar + "," + reader["titol"].ToString();
                             }
                             menusAEliminar++;
                         }
                         else
                         {
                             menus = reader["titol"].ToString();
                             numeroDeMenus++;
                         }
                     }
                     else
                     {
                         if (reader["numeroproductes"].ToString().Equals("1"))
                         {
                             if (menusAEliminar == 0)
                             {
                                 menusEliminar = reader["titol"].ToString();
                             }
                             else
                             {
                                 menusEliminar = menusEliminar + "," + reader["titol"].ToString();
                             }
                             menusAEliminar++;
                         }
                         else
                         {
                             menus = menus + "," + reader["titol"].ToString();
                             numeroDeMenus++;
                         }
                     }

                 }
             }
             reader.Close();

             if (numeroDeMenus > 0)
             {
                 String sentencia2 = "delete productesformamenu from productesformamenu where idproducte = " + idProducte;
                 MySqlCommand cmd2 = new MySqlCommand(sentencia2, this.conn);
                 if (numeroDeMenus == 1)
                 {
                     var result = DialogResult.OK;
                     if (menusAEliminar == 0)
                     {
                         result = MessageBox.Show("Aquest producte forma part del menu " + menus + " si l'elimina també s'eliminara del menu, estas segur que desitges continuar? ", "Aquest producte forma part d'un menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                     }
                     else if (menusAEliminar == 1)
                     {
                         result = MessageBox.Show("Aquest producte forma part del menu " + menus + " si l'elimina també s'eliminara del menu i el menu " + menusEliminar + " s'eliminara completament ja que aquest es l'ultim producte, estas segur que desitges continuar? ", "Aquest producte forma part d'un menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                         if (result == DialogResult.OK)
                         {
                             this.eliminarMenuSenseProducte(menusEliminar);
                         }
                     }
                     else if (menusAEliminar > 1)
                     {
                         result = MessageBox.Show("Aquest producte forma part del menu " + menus + " si l'elimina també s'eliminara del menu i els menus " + menusEliminar + " s'eliminaran completament ja que aquests l'ultim producte dels menus anteriorment anomenats, estas segur que desitges continuar? ", "Aquest producte forma part d'un menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                         if (result == DialogResult.OK)
                         {
                             string valorMenuAEliminar = menusEliminar;
                             string[] titulosmenu = valorMenuAEliminar.Split(',');
                             foreach (string palabra in titulosmenu)
                             {
                                 this.eliminarMenuSenseProducte(palabra);
                             }
                         }
                     }
                     if (result == DialogResult.OK)
                     {
                         try
                         {
                             cmd2.ExecuteNonQuery();
                         }
                         catch (Exception e)
                         {
                             MessageBox.Show("Per motius que desconeixem, no hem sigut capaços d'eliminar el producte, intenti-ho més tard. Disculpi les molesties ", "Impossible eliminar el producte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             retorn = false;
                         }

                     }
                     else
                     {
                         retorn = false;
                     }
                 }
                 else
                 {
                     var result = DialogResult.OK;
                     if (menusAEliminar == 0)
                     {
                         result = MessageBox.Show("Aquest producte forma part dels següents menus: " + menus + ", si l'elimina també s'eliminara dels menus anteriorment anomenats, estas segur que desitges continuar? ", "Aquest producte forma de diferents menus!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                     }
                     else if (menusAEliminar == 1)
                     {
                         result = MessageBox.Show("Aquest producte forma part dels següents menus: " + menus + " si l'elimina també s'eliminara del menu, ademes el menu " + menusEliminar + " s'eliminara completament ja que aquest es l'ultim producte, estas segur que desitges continuar? ", "Aquest producte forma part d'un menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                         if (result == DialogResult.OK)
                         {
                             this.eliminarMenuSenseProducte(menusEliminar);
                         }
                     }
                     else if (menusAEliminar > 1)
                     {
                         result = MessageBox.Show("Aquest producte forma part dels següents menus: " + menus + " si l'elimina també s'eliminaran del menus, ademes els menus " + menusEliminar + " s'eliminaran completament ja que aquests l'ultim producte dels menus anteriorment anomenats, estas segur que desitges continuar? ", "Aquest producte forma part d'un menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                         if (result == DialogResult.OK)
                         {
                             string valorMenuAEliminar = menusEliminar;
                             string[] titulosmenu = valorMenuAEliminar.Split(',');
                             foreach (string palabra in titulosmenu)
                             {
                                 this.eliminarMenuSenseProducte(palabra);
                             }
                         }
                     }

                     if (result == DialogResult.OK)
                     {
                         try
                         {
                             cmd2.ExecuteNonQuery();
                         }
                         catch (Exception e)
                         {
                             MessageBox.Show("Per motius que desconeixem, no hem sigut capaços d'eliminar el producte, intenti-ho més tard. Disculpi les molesties ", "Impossible eliminar el producte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             retorn = false;
                         }
                     }
                     else
                     {
                         retorn = false;
                     }
                 }
             }
             else
             {
                 var result = DialogResult.OK;
                 String sentencia2 = "delete productesformamenu from productesformamenu where idproducte = " + idProducte;
                 MySqlCommand cmd2 = new MySqlCommand(sentencia2, this.conn);
                 if (menusAEliminar == 1)
                 {
                     result = MessageBox.Show("Aquest producte forma part del menu " + menusEliminar + " i aquest s'eliminara completament ja que el producte que desitga eliminar es l'ultim producte, estas segur que desitges continuar? ", "Aquest producte forma part d'un menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                     if (result == DialogResult.OK)
                     {
                         this.eliminarMenuSenseProducte(menusEliminar);
                     }
                     if (result == DialogResult.OK)
                     {
                         try
                         {
                             cmd2.ExecuteNonQuery();
                         }
                         catch (Exception e)
                         {
                             MessageBox.Show("Per motius que desconeixem, no hem sigut capaços d'eliminar el producte, intenti-ho més tard. Disculpi les molesties ", "Impossible eliminar el producte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             retorn = false;
                         }
                     }
                     else
                     {
                         retorn = false;
                     }
                 }
                 else if (menusAEliminar > 1)
                 {
                     result = MessageBox.Show("Aquest producte forma part dels següents menus: " + menusEliminar + " i aquest s'eliminaran completament ja que el producte que desitga eliminar es l'ultim producte dels menus anteriorment anomenats, estas segur que desitges continuar? ", "Aquest producte forma part d'un menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                     if (result == DialogResult.OK)
                     {
                         string valorMenuAEliminar = menusEliminar;
                         string[] titulosmenu = valorMenuAEliminar.Split(',');
                         foreach (string palabra in titulosmenu)
                         {
                             this.eliminarMenuSenseProducte(palabra);
                         }
                     }
                     if (result == DialogResult.OK)
                     {
                         try
                         {
                             cmd2.ExecuteNonQuery();
                         }
                         catch (Exception e)
                         {
                             MessageBox.Show("Per motius que desconeixem, no hem sigut capaços d'eliminar el producte, intenti-ho més tard. Disculpi les molesties ", "Impossible eliminar el producte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             retorn = false;
                         }
                     }
                     else
                     {
                         retorn = false;
                     }
                 }
                 
             }
            return retorn;
        }
        private List<cMenu> omplirProductesAMenus(List<cMenu> llista)
        {
            List<cMenu> coleccioMenus = new List<cMenu>();
            coleccioMenus = llista;            

            for (int i = 0; i < llista.Count(); i++)
            {
                byte[] aByte;
                List<cProducte> coleccioProductes = new List<cProducte>();
                String sentencia = "SELECT p.idproducte as id, p.nomproducte as nom, p.tipusproducte as tipus,p.iconaproducte as icona,p.fotoproducte as foto, p.preuproducte as preu, d.iddescripcio as descripcio " +
                                   "from producte p,descripcio d, productesformamenu pfm,menu m " +
                                   "where p.idProducte = d.idProducte " +
                                   "and p.idproducte = pfm.idproducte " +
                                   "and m.idmenu = pfm.idmenu " +
                                   "and m.idmenu = " + coleccioMenus[i].getIdMenu();
                MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String id, nom, tipus, preu, descripcio = "";
                    String icona, imatge;
                    id = reader["id"].ToString();
                    nom = reader["nom"].ToString();
                    tipus = reader["tipus"].ToString();
                    #region tractarIcona
                        icona = this.llegirImatgeProductesMenu(reader["icona"].ToString());
                    #endregion
                    #region tractarImatge
                        imatge = this.llegirImatgeProductesMenu(reader["foto"].ToString());
                    #endregion                
                    preu = reader["preu"].ToString();
                    descripcio = reader["descripcio"].ToString();
                    cProducte p = new cProducte(id, nom, tipus, icona, imatge, preu, descripcio);
                    coleccioProductes.Add(p);
                }
                reader.Close();
                coleccioMenus[i].setColeccioProductes(coleccioProductes);
            }
            return coleccioMenus;
        }
        public String saberId(String sentencia)
        {
            String retorn = "";
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["id"] != null)
                {
                    try
                    {
                        retorn = reader["id"].ToString();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                {
                    retorn = "";
                }
            }
            reader.Close(); 
            return retorn;
        }
        private String saberUltimaId(String tipusProducte)
        {
            String retorn = "";
            String sentencia = "SELECT MAX(id" + tipusProducte + ") as id FROM " + tipusProducte;
            MySqlCommand cmd = new MySqlCommand(sentencia, this.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["id"] != null)
                {
                    try
                    {
                        retorn = reader["id"].ToString();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                {
                    retorn = "";
                }
            }
            reader.Close();
            return retorn;
        }
        private String nomImatgePath(String path)
        {
            String nomImatge = "";
            string[] words = path.Split('\\');
            foreach (string word in words)
            {
                nomImatge = word;
            }
            return nomImatge;
        }
        private String llegirImatgeProductes(String id, String tipusImatge,String nomImatge)
        {
            String retorn = "";
            String path = "";
            String path1 = "";
            if (tipusImatge.Equals("Icona"))
            {
                path = this.directori + "\\Productes\\" + id + "\\Icona\\";
                path1 = this.directori + "\\Productes\\" + id + "\\Icona\\" + nomImatge;
            }
            else
            {
                path = this.directori + "\\Productes\\" + id + "\\Imatge\\";
                path1 = this.directori + "\\Productes\\" + id + "\\Imatge\\" + nomImatge;
            }
            // || !System.IO.Directory.Exists(path1)
            if (!System.IO.Directory.Exists(path) || nomImatge.Equals(""))
            {
                System.IO.Directory.CreateDirectory(path);
                System.IO.File.Copy(this.imatgePerDefecte, path + this.nomImatgePerDefecte, true);
                retorn = this.nomImatgePerDefecte;
            }
            else
            {
                if (nomImatge.Equals(""))
                {
                    retorn = this.nomImatgePerDefecte;
                }
                else
                {
                    retorn = nomImatge;
                }
            }
            return retorn;
        }
        private String llegirImatgeMenu(String id, String nomImatge)
        {
            String retorn = "";
            String path = this.directori + "\\Menus\\" + id + "\\Imatge\\";
            String path1 = this.directori + "\\Menus\\" + id + "\\Imatge\\" + nomImatge;

            // || !System.IO.Directory.Exists(path1)
            if (!System.IO.Directory.Exists(path) || nomImatge.Equals(""))
            {
                System.IO.Directory.CreateDirectory(path);
                System.IO.File.Copy(this.imatgePerDefecte, path + this.nomImatgePerDefecte, true);
                retorn = this.nomImatgePerDefecte;
            }
            else
            {
                if (nomImatge.Equals(""))
                {
                    retorn = this.nomImatgePerDefecte;
                }
                else
                {
                    retorn = nomImatge;
                }
            }
            return retorn;
        }
        private String llegirImatgeProductesMenu(String imatge)
        {
            String retorn = "";
            if (imatge.Equals("") || imatge == null)
            {
                retorn = this.nomImatgePerDefecte;
            }
            else
            {
                if (imatge.Equals(""))
                {
                    retorn = this.nomImatgePerDefecte;
                }
                else
                {
                    retorn = imatge;
                }
            }
            return retorn;
        }
        private Boolean eliminarCarpetaMenu(String idMenu)
        {
            Boolean retorn = true;
            try
            {
                Directory.Delete(this.directori + "\\Menus\\" + idMenu, true);
            }
            catch (System.IO.IOException e)
            {
                retorn = false;
            }
            return retorn;
        }
        public String getDirectori()
        {
            return this.directori;
        }
    }
}