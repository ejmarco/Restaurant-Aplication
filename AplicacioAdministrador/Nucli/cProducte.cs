using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AplicacioAdministrador.Nucli
{
    class cProducte
    {
        private String idProducte;
        private String nomProducte;
        private String tipusProducte;
        private String iconaProducte;
        private String imatgeProducte;
        private String preuProducte;
        private String descripcioProducte;

        public cProducte(String id,String nom,String tipus,String icona,String imatge,String preu,String descripcio)
        {
            this.idProducte = id;
            this.nomProducte = nom;
            this.tipusProducte = tipus;
            this.iconaProducte = icona;
            this.imatgeProducte = imatge;
            this.preuProducte = preu;
            this.descripcioProducte = descripcio;
        }
        public cProducte(String nom, String tipus, String icona, String imatge, String preu, String descripcio)
        {
            this.nomProducte = nom;
            this.tipusProducte = tipus;
            this.iconaProducte = icona;
            this.imatgeProducte = imatge;
            this.preuProducte = preu;
            this.descripcioProducte = descripcio;
        }
        #region Getter
            public String getIdProducte()
            {
                return this.idProducte;
            }
            public String getNomProducte()
            {
                return this.nomProducte;
            }
            public String getTipusProducte()
            {
                return this.tipusProducte;
            }
            public String getIconaProducte()
            {
                return this.iconaProducte;
            }
            public String getImatgeProducte()
            {
                return this.imatgeProducte;
            }
            public String getPreuProducte()
            {
                return this.preuProducte;
            }
            public String getDescripcioProducte()
            {
                return this.descripcioProducte;
            }
        #endregion
        #region Setter
            public void setIdProducte(String id)
            {
                this.idProducte = id;
            }
            public void setNomProducte(String nom)
            {
                this.nomProducte = nom;
            }
            public void setTipusProducte(String tipus)
            {
                this.tipusProducte = tipus;
            }
            public void setIconaProducte(String icona)
            {
                this.iconaProducte = icona;
            }
            public void setImatgeProducte(String img)
            {
                this.imatgeProducte = img;
            }
            public void setPreuProducte(String preu)
            {
                this.preuProducte = preu;
            }
            public void setDescripcioProducte(String desc)
            {
                this.descripcioProducte = desc;
            }
        #endregion
    }
}
