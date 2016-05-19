using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AplicacioAdministrador.Nucli
{
    class cMenu
    {
        private String idMenu;
        private String titolMenu;
        private String preuMenu;
        private String disponibilitatMenu;
        private String imatgeMenu;
        private List<cProducte> coleccioProductes = new List<cProducte>();

        public cMenu(List<cProducte> productes){
            this.coleccioProductes = productes;
        }
        public cMenu(String id, String titol, String preu, String disponibilitat, String imatge)
        {
            this.idMenu = id;
            this.titolMenu = titol;
            this.preuMenu = preu;
            this.disponibilitatMenu = disponibilitat;
            this.imatgeMenu = imatge;
        }
        public cMenu(String titol, String preu, String disponibilitat, String imatge, List<cProducte> llista)
        {
            this.titolMenu = titol;
            this.preuMenu = preu;
            this.disponibilitatMenu = disponibilitat;
            this.imatgeMenu = imatge;
            this.coleccioProductes = llista;
        }

        #region Getter
            public String getIdMenu()
            {
                return this.idMenu;
            }
            public String getTitolMenu()
            {
                return this.titolMenu;
            }
            public String getPreuMenu()
            {
                return this.preuMenu;
            }
            public String getDisponibilitatMenu()
            {
                return this.disponibilitatMenu;
            }
            public String getImatgeMenu()
            {
                return this.imatgeMenu;
            }
            public List<cProducte> getColeccioProductes()
            {
                return this.coleccioProductes;
            }
        #endregion
        #region Setter
            public void setIdMenu(String id)
            {
                this.idMenu = id;
            }
            public void setTitolMenu(String titol)
            {
                this.titolMenu = titol;
            }
            public void setPreuMenu(String preu)
            {
                this.preuMenu = preu;
            }
            public void setDisponibilitatMenu(String dispon)
            {
                this.disponibilitatMenu = dispon;
            }
            public void setImatgeMenu(String img)
            {
                this.imatgeMenu = img;
            }
            public void setColeccioProductes(List<cProducte> list)
            {
                this.coleccioProductes = list;
            }
        #endregion
    }
}
