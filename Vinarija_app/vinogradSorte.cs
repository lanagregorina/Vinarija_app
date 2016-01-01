using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class vinogradSorte
    {
        public vinogradSorte() 
        { 
        }

        public vinogradSorte(DbDataReader dr)
        {
            if (dr != null)
            {
                idVinogradSorte = int.Parse(dr["idVinogradSorte"].ToString());
                idVinograd = int.Parse(dr["idVinograd"].ToString());
                idSorte = int.Parse(dr["idSorte"].ToString());
                brCokota = int.Parse(dr["brCokota"].ToString());
                smjestaj = dr["smjestaj"].ToString();
                datumSadnje = dr["datumSadnje"].ToString();
                
            }
        }

        private int id;
        private string smjestajVS;
        private string datumSadnjeVS;
        private int brCokotaVS;
        private int idVinogradVS;
        private int idSorteVS;

        public int idVinogradSorte
        {
            get
            {
                return id;
            }
            private set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }


        public string smjestaj
        {
            get
            {
                return smjestajVS;
            }
            set
            {
                if (smjestajVS != value)
                {
                    smjestajVS = value;
                }
            }
        }

        public string datumSadnje
        {
            get
            {
                return datumSadnjeVS;
            }
            set
            {
                if (datumSadnjeVS != value)
                {
                    datumSadnjeVS = value;
                }
            }
        }

        
        public int brCokota
        {
            get
            {
                return brCokotaVS;
            }
            set
            {
                if (brCokotaVS != value)
                {
                    brCokotaVS = value;
                }
            }
        }

        public int idVinograd
        {
            get
            {
                return idVinogradVS;
            }
            set
            {
                if (idVinogradVS != value)
                {
                    idVinogradVS = value;
                }
            }
        }

        public int idSorte
        {
            get
            {
                return idSorteVS;
            }
            set
            {
                if (idSorteVS != value)
                {
                    idSorteVS = value;
                }
            }
        }

         
        public int Spremi()
        {
            string sqlUpit = "";

            if (idVinogradSorte == 0)        
            {
                sqlUpit = "INSERT INTO vinograd_ima_sorte (idVinogradSorte, idVinograd, idSorte, brCokota, smjestaj, datumSadnje) "
                        + "VALUES (null, '" + idVinograd + "','" + idSorte + "','" + brCokota + "','" + smjestaj+ "','" + datumSadnje + "')";
            }
            else                
            {
                sqlUpit = "UPDATE vinograd_ima_sorte SET idVinograd = '" + idVinograd
                + "', idSorte = '" + idSorte
                + "', brCokota = '" + brCokota
                + "', smjestaj = '" + smjestaj
                + "', datumSadnje = '" + datumSadnje
                + "' WHERE idVinogradSorte = " + idVinogradSorte;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM vinograd_ima_sorte WHERE idVinogradSorte = " + idVinogradSorte;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

      
        public static List<vinogradSorte> DohvatiVinogradSorte()
        {
            List<vinogradSorte> lista = new List<vinogradSorte>();

            string sqlUpit = "SELECT * FROM vinograd_ima_sorte";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                vinogradSorte vinogradSorte = new vinogradSorte(dr);
                lista.Add(vinogradSorte);
            }
            dr.Close();
            return lista;
        }

        public override string ToString()
        {
            return smjestaj;
        }
    }
}
