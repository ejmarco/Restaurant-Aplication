using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplicacioAdministrador.Formularis.Login;
using AplicacioAdministrador.Formularis.Principal;

namespace AplicacioAdministrador.Nucli
{
    class cEngine
    {
        private cMySql bdd;
        private static String usuari;
        private static String password;
        private static Boolean conectarse = true;
        private String tipusUsuari;


        public static String getUsuari()
        {
            return cEngine.usuari;
        }

        public static void setUsuari(String usuari)
        {
            cEngine.usuari = usuari;
        }


        public static String getPassword()
        {
            return cEngine.password;
        }

        public static void setPassword(String password)
        {
            cEngine.password = password;
        }
        public static Boolean getConectarse()
        {
            return cEngine.conectarse;
        }

        public static void setConectarse(Boolean conectarseParametre)
        {
            cEngine.conectarse = conectarseParametre;
        }


        public cEngine()
        {
        }

        public void executar()
        {

            while (conectarse)
            {
                bdd = new cMySql();
                Application.Run(new frmLogin());
                tipusUsuari = bdd.tipusUsuari(cEngine.usuari, cEngine.password);
                if (tipusUsuari == "Administrador")
                {
                    Application.Run(new frmPrincipal(bdd.nomUsuari(cEngine.usuari, cEngine.password)));
                }
                else
                {
                    if (this.tipusUsuari.Equals("error") && cEngine.getConectarse() == true)
                    {
                        MessageBox.Show("Aquest usuari no existeix o no te els privilegis suficients");
                    }
                    else
                    {
                        cEngine.setConectarse(false);
                    }

                    // 
                    //conectarse = true;
                }
                //HACER UN BOTON SALIR EN EL LOGIN
            }
       }

            //{
            //    do
            //    {
            //        Application.Run(new frmMenuInicial());
            //        if (cEngine.pantallaSeguent == "AltaServei") Application.Run(new frmAltaNouServei());
            //        if (cEngine.pantallaSeguent == "AltaClient") Application.Run(new frmAltaNouClient());
            //        if (cEngine.pantallaSeguent == "AltaReserva") Application.Run(new frmAltaNovaReserva());
            //        if (cEngine.pantallaSeguent == "AltaHotel") Application.Run(new frmAltaNouHotel());
            //        if (cEngine.pantallaSeguent == "ConsultaServei") Application.Run(new frmConsultarServeis());
            //        if (cEngine.pantallaSeguent == "ConsultaClient") Application.Run(new frmConsultarClients());
            //        if (cEngine.pantallaSeguent == "ConsultaReserva") Application.Run(new frmConsultarReserva());
            //        if (cEngine.pantallaSeguent == "ConsultaHotel") Application.Run(new frmConsultarHotels());

            //    } while (cEngine.pantallaSeguent != "sortir");
            //}
            //else
            //    MessageBox.Show("L'usuari ha de ser administrador.");
            public cMySql agafarcMySql()
                {
                    return bdd;
                }

            public Boolean buscarAdministrador(String nomUsuari, String password)
            {
                return false;
            }
    }
}
