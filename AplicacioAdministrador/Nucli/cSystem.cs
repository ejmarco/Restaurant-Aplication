using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AplicacioAdministrador.Nucli
{
   class cSystem
    {
        private List<cProducte> coleccioProductes = new List<cProducte>();
        private List<cMenu> coleccioMenus = new List<cMenu>();
        private String directori = "";
        private cMySql bdd = new cMySql();
        public cSystem()
        {
            this.coleccioProductes = bdd.omplirColeccioProductes();
            this.coleccioMenus = bdd.omplirColeccioMenus();
            this.directori = bdd.getDirectori();
        }
        public void omplirColeccioProductes()
        {
            //OMPLIR ELS COMBOS AL CREAR EL CSYSTEM
        }
        public void uptdate()
        {
            this.coleccioProductes = bdd.omplirColeccioProductes();
            this.coleccioMenus = bdd.omplirColeccioMenus();
        }
        public Boolean cambiarVisibilitat(String idMenu, String visibilitat)
        {
            return bdd.cambiarVisibilitat(idMenu, visibilitat);
        }
      
        
        public List<cProducte> getColeccioProductes()
        {
            return this.coleccioProductes;
        }
        public List<cMenu> getColeccioMenus()
        {
            return this.coleccioMenus;
        }
        public Boolean insertarProducte(cProducte pro)
        {
            Boolean retorn = true;
            String idProducte = bdd.insertarProducte(pro);
            if (idProducte != "")
            {
                String pathIcona = this.directori + "\\Productes\\" + idProducte + "\\Icona\\";
                String pathImatge = this.directori + "\\Productes\\" + idProducte + "\\Imatge\\";

                System.IO.Directory.CreateDirectory(pathIcona);
                System.IO.Directory.CreateDirectory(pathImatge);

                String icona = this.nomImatgePath(pro.getIconaProducte());
                String imatge = this.nomImatgePath(pro.getImatgeProducte());
                System.IO.File.Copy(pro.getIconaProducte(), pathIcona + icona, true);
                System.IO.File.Copy(pro.getImatgeProducte(), pathImatge + imatge, true);
            }
            else
            {
                retorn = false;
            }
            return retorn;
        }
        public Boolean modificarProducte(String idProducte, cProducte producteModificat)
        {
            Boolean retorn = true;
            if (bdd.modificarProducte(idProducte, producteModificat))
            {
                String pathIcona = this.directori + "\\Productes\\" + idProducte + "\\Icona\\";
                String pathImatge = this.directori + "\\Productes\\" + idProducte + "\\Imatge\\";
                if (!System.IO.Directory.CreateDirectory(pathIcona).Exists)
                {
                    System.IO.Directory.CreateDirectory(pathIcona);
                }
                if (!System.IO.Directory.CreateDirectory(pathImatge).Exists)
                {
                    System.IO.Directory.CreateDirectory(pathImatge);
                }
                

                String icona = this.nomImatgePath(producteModificat.getIconaProducte());
                String imatge = this.nomImatgePath(producteModificat.getImatgeProducte());
                try
                {
                    System.IO.File.Copy(producteModificat.getIconaProducte(), pathIcona + icona, true);
                }
                catch (Exception ex)
                {
                }
                try
                {
                    System.IO.File.Copy(producteModificat.getImatgeProducte(), pathImatge + imatge, true);
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                retorn = false;
            }
            return retorn;
        }
        public Boolean eliminarProducte(String idProducte)
        {
            Boolean retorn = bdd.eliminarProducte(idProducte);
            if (retorn)
            {
                try
                {
                    Directory.Delete(this.directori + "\\Productes\\" + idProducte, true);
                }
                catch (System.IO.IOException e)
                {
                    retorn = false;
                }
            }
            return retorn;
        }
        public Boolean insertarMenu(cMenu menu)
        {
            Boolean retorn = true;
            String idMenu = bdd.insertarMenu(menu);
            if (idMenu != "")
            {
                String pathImatge = this.directori + "\\Menus\\" + idMenu + "\\Imatge\\";
                System.IO.Directory.CreateDirectory(pathImatge);
                String imatge = this.nomImatgePath(menu.getImatgeMenu());
                System.IO.File.Copy(menu.getImatgeMenu(), pathImatge + imatge, true);
            }
            else
            {
                retorn = false;
            }
            return retorn;
        }
        public Boolean modificarMenu(String idMenu, cMenu menuModificat)
        {
            Boolean retorn = true;
            if (bdd.modificarMenu(idMenu, menuModificat))
            {
                String pathImatge = this.directori + "\\Menus\\" + idMenu + "\\Imatge\\";
                if (!System.IO.Directory.CreateDirectory(pathImatge).Exists)
                {
                    System.IO.Directory.CreateDirectory(pathImatge);
                }


                String imatge = this.nomImatgePath(menuModificat.getImatgeMenu());
                try
                {
                    System.IO.File.Copy(menuModificat.getImatgeMenu(), pathImatge + imatge, true);
                }
                catch (Exception ex)
                {
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
            Boolean retorn = bdd.eliminarMenu(idMenu);
            if (retorn)
            {
                try
                {
                    Directory.Delete(this.directori + "\\Menus\\" + idMenu, true);
                }
                catch (System.IO.IOException e)
                {
                    retorn = false;
                }
            }
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
        public String getDirectori()
        {
            return this.directori;
        }
      
    }
}
