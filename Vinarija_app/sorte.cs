using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class sorte
    {
        public sorte() { }
        
        public sorte(DbDataReader dr)
        {
            if (dr != null)
            {
                idSorte = int.Parse(dr["idSorte"].ToString());
                naziv = dr["naziv"].ToString();
            }
        }

        private int id;
        private string nazivS;
        

        public int idSorte
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

       
        public string naziv
        {
            get
            {
                return nazivS;
            }
            set
            {
                if (nazivS != value)
                {
                    nazivS = value;
                }
            }
        }

        
       

    
        public int Spremi()
        {
            string sqlUpit = "";

            if (idSorte == 0)       
            {
                sqlUpit = "INSERT INTO sorte (idSorte, naziv) "
                        + "VALUES (null, '" + naziv + "')";
            }
            else                
            {
                sqlUpit = "UPDATE sorte SET naziv = '" + naziv
                + "' WHERE idSorte = " + idSorte;
            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM sorte WHERE idSorte = " + idSorte;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

        
        public static List<sorte> DohvatiSorte()
        {
            List<sorte> lista = new List<sorte>();

            string sqlUpit = "SELECT * FROM sorte";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                sorte popis = new sorte(dr);
                lista.Add(popis);
            }
            dr.Close();
            return lista;
        }

        public override string ToString()
        {
            return naziv;

        }

    }
}
