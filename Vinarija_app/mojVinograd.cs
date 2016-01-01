using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class mojVinograd
    {
        public mojVinograd() 
        {
        }

        public mojVinograd(DbDataReader dr)
        {
            if (dr != null)
            {
                idVinograd = int.Parse(dr["idVinograd"].ToString());
                naziv = dr["naziv"].ToString();
                lokacija = dr["lokacija"].ToString();
                brCokota = int.Parse(dr["brCokota"].ToString());
                brRedova = int.Parse(dr["brRedova"].ToString());
                
            }
        }

        private int id;
        private string nazivV;
        private string lokacijaV;
        private int brCokotaV;
        private int brRedovaV;
        

        public int idVinograd
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
                return nazivV;
            }
            set
            {
                if (nazivV != value)
                {
                    nazivV = value;
                }
            }
        }

        public string lokacija
        {
            get
            {
                return lokacijaV;
            }
            set
            {
                if (lokacijaV != value)
                {
                    lokacijaV = value;
                }
            }
        }

        
        public int brCokota
        {
            get
            {
                return brCokotaV;
            }
            set
            {
                if (brCokotaV != value)
                {
                    brCokotaV = value;
                }
            }
        }

        public int brRedova
        {
            get
            {
                return brRedovaV;
            }
            set
            {
                if (brRedovaV != value)
                {
                    brRedovaV = value;
                }
            }
        }


        
        public int Spremi()
        {
            string sqlUpit = "";

            if (idVinograd == 0)       
            {
                sqlUpit = "INSERT INTO vinograd (idVinograd, naziv, lokacija, brCokota, brRedova) "
                        + "VALUES (null, '" + naziv + "','" + lokacija + "','" + brCokota + "','" + brRedova + "')";
            }
            else               
            {
                sqlUpit = "UPDATE vinograd SET naziv = '" + naziv
                + "', lokacija = '" + lokacija
                + "', brCokota = '" + brCokota
                + "', brRedova = '" + brRedova
                + "' WHERE idVinograd = " + idVinograd;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM vinograd WHERE idVinograd = " + idVinograd;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

        
        public static List<mojVinograd> DohvatiVinograd()
        {
            List<mojVinograd> lista = new List<mojVinograd>();

            string sqlUpit = "SELECT * FROM vinograd";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                mojVinograd vinograd = new mojVinograd(dr);
                lista.Add(vinograd);
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
