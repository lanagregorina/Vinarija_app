using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class vinoAmbalaza
    {
        public vinoAmbalaza() 
        {
        }

        
        public vinoAmbalaza(DbDataReader dr)
        {
            if (dr != null)
            {
                idAmbalazaVina = int.Parse(dr["idAmbalazaVina"].ToString());
                idVino = int.Parse(dr["idVino"].ToString());
                idAmbalaza = int.Parse(dr["idAmbalaza"].ToString());
                datum = dr["datum"].ToString();
                kolicina = float.Parse(dr["kolicina"].ToString());
                
            }
        }

        private int id;
        private int idVinoVA;
        private int idAmbalazaVA;
        private string datumVA;
        private float kolicinaVA;





        public int idAmbalazaVina
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

       
        public string datum
        {
            get
            {
                return datumVA;
            }
            set
            {
                if (datumVA != value)
                {
                    datumVA = value;
                }
            }
        }

        
        public float kolicina
        {
            get
            {
                return kolicinaVA;
            }
            set
            {
                if (kolicinaVA != value)
                {
                    kolicinaVA = value;
                }
            }
        }


        public int idVino
        {
            get
            {
                return idVinoVA;
            }
            set
            {
                if (idVinoVA != value)
                {
                    idVinoVA = value;
                }
            }
        }

        public int idAmbalaza
        {
            get
            {
                return idAmbalazaVA;
            }
            set
            {
                if (idAmbalazaVA != value)
                {
                    idAmbalazaVA = value;
                }
            }
        }
       
        public int Spremi()
        {
            string sqlUpit = "";

            if (idAmbalazaVina == 0)        
            {
                sqlUpit = "INSERT INTO vinoAmbalaza (idAmbalazaVina, idVino, idAmbalaza, kolicina, datum) "
                        + "VALUES (null, '" + idVino + "','" + idAmbalaza + "','" + kolicina + "','" + datum + "')";
            }
            else             
            {
                sqlUpit = "UPDATE vinoAmbalaza SET idVino = '" + idVino
                + "', idAmbalaza = '" + idAmbalaza
                + "', kolicina = '" + kolicina
                + "', datum = '" + datum
                + "' WHERE idAmbalazaVina = " + idAmbalazaVina;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM vinoAmbalaza WHERE idAmbalazaVina = " + idAmbalazaVina;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

      
        public static List<vinoAmbalaza> DohvatiVinoAmbalaza()
        {
            List<vinoAmbalaza> lista = new List<vinoAmbalaza>();

            string sqlUpit = "SELECT * FROM vinoAmbalaza";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                vinoAmbalaza VinoAmbalaza = new vinoAmbalaza(dr);
                lista.Add(VinoAmbalaza);
            }
            dr.Close();
            return lista;
        }

        public override string ToString()
        {
            return datum;

        }
    }
}
