using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class dnevnikVinogradara
    {
         public dnevnikVinogradara() 
        {
        }

         public dnevnikVinogradara(DbDataReader dr)
        {
            if (dr != null)
            {
                idDnevnikV = int.Parse(dr["idDnevnikV"].ToString());
                datum = dr["datum"].ToString();
                aktivnosti = dr["aktivnosti"].ToString();
                opazanja = dr["opazanja"].ToString();
                idVinograd = int.Parse(dr["idVinograd"].ToString());
  
            }
        }


        private int idDnevnikVin;
        private string datumV;
        private string aktivnostiV;
        private string opazanjaV;
        private int vinogradV;

        public int idDnevnikV
        {
            get
            {
                return idDnevnikVin;
            }
            set
            {
                if (idDnevnikVin != value)
                {
                    idDnevnikVin = value;
                }
            }
        }

        
        public string datum
        {
            get
            {
                return datumV;
            }
            set
            {
                if (datumV != value)
                {
                    datumV = value;
                }
            }
        }

       
        public string aktivnosti
        {
            get
            {
                return aktivnostiV;
            }
            set
            {
                if (aktivnostiV != value)
                {
                    aktivnostiV = value;
                }
            }
        }

        
        public string opazanja
        {
            get
            {
                return opazanjaV;
            }
            set
            {
                if (opazanjaV != value)
                {
                    opazanjaV = value;
                }
            }
        }

        public int idVinograd
        {
            get
            {
                return vinogradV;
            }
            set
            {
                if (vinogradV != value)
                {
                    vinogradV = value;
                }
            }
        }


        public int Spremi()
        {
            string sqlUpit = "";

            if (idDnevnikV == 0)        //Ako se radi o novokreiranom dnevniku tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO dnevnikVinogradara (idDnevnikV, datum, aktivnosti, opazanja, idVinograd) "
                        + "VALUES (null, '" + datum + "','" + aktivnosti + "','" + opazanja + "','" + idVinograd + "')";
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE dnevnikVinogradara SET datum = '" + datum
                + "', aktivnosti = '" + aktivnosti
                + "', opazanja = '" + opazanja
                + "', idVinograd = '" + idVinograd
                + "' WHERE idDnevnikV = " + idDnevnikV;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM dnevnikVinogradara WHERE idDnevnikV = " + idDnevnikV;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }


        

        public static List<dnevnikVinogradara> DohvatiDnevnik()
        {
            List<dnevnikVinogradara> lista = new List<dnevnikVinogradara>();

            string sqlUpit = "SELECT * FROM dnevnikVinogradara";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                dnevnikVinogradara dnevnikVinogradara = new dnevnikVinogradara(dr);
                lista.Add(dnevnikVinogradara);
            }
            dr.Close();
            return lista;
        }

        public override string ToString()
        {
            return aktivnosti;

        }



    }
}
