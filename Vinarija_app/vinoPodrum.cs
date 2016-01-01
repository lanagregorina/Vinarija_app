using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class vinoPodrum
    {
        public vinoPodrum() 
        {
        }

        
        public vinoPodrum(DbDataReader dr)
        {
            if (dr != null)
            {
                idVino = int.Parse(dr["idVino"].ToString());
                idBerbe = int.Parse(dr["idBerbe"].ToString());
                opis = dr["opis"].ToString();
                kolicina = float.Parse(dr["kolicinaD"].ToString());
                ostalo = float.Parse(dr["ostalo"].ToString());
            }
        }

        private int id;
        private int idBerbeVP;
        private string opisVP;
        private float kolicinaVP;
        private float ostaloVP;

        
        

        public int idVino
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

       
        public string opis
        {
            get
            {
                return opisVP;
            }
            set
            {
                if (opisVP != value)
                {
                    opisVP = value;
                }
            }
        }

        
        public float kolicina
        {
            get
            {
                return kolicinaVP;
            }
            set
            {
                if (kolicinaVP != value)
                {
                    kolicinaVP = value;
                }
            }
        }

        public float ostalo
        {
            get
            {
                return ostaloVP;
            }
            set
            {
                if (ostaloVP != value)
                {
                    ostaloVP = value;
                }
            }
        }

        public int idBerbe
        {
            get
            {
                return idBerbeVP;
            }
            set
            {
                if (idBerbeVP != value)
                {
                    idBerbeVP = value;
                }
            }
        }

        
        public int Spremi()
        {
            string sqlUpit = "";

            if (idVino == 0)        
            {
                sqlUpit = "INSERT INTO vinoPodrum (idVino, idBerbe, opis, kolicinaD, ostalo) "
                        + "VALUES (null, '" + idBerbe + "','" + opis + "','" + kolicina + "','" + ostalo + "')";
            }
            else               
            {
                sqlUpit = "UPDATE vinoPodrum SET idBerbe = '" + idBerbe
                + "', opis = '" + opis
                + "', kolicinaD = '" + kolicina
                + "', ostalo = '" + ostalo
                + "' WHERE idVino = " + idVino;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM vinoPodrum WHERE idVino = " + idVino;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

       
        public static List<vinoPodrum> DohvatiPodrum()
        {
            List<vinoPodrum> lista = new List<vinoPodrum>();

            string sqlUpit = "SELECT * FROM vinoPodrum";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                vinoPodrum podrum = new vinoPodrum(dr);
                lista.Add(podrum);
            }
            dr.Close();
            return lista;
        }

        public override string ToString()
        {
            return opis;

        }
    }
}
