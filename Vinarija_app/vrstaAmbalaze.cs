using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class vrstaAmbalaze
    {
        public vrstaAmbalaze()
        {
        }

        
        public vrstaAmbalaze(DbDataReader dr)
        {
            if (dr != null)
            {
                idAmbalaza = int.Parse(dr["idAmbalaza"].ToString());
                vrsta = dr["vrsta"].ToString();
                zapremnina = float.Parse(dr["zapremnina"].ToString());
                
            }
        }

        private int id;
        private string vrstaA;
        private float zapremninaA;

        

        public int idAmbalaza
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

       
        public string vrsta
        {
            get
            {
                return vrstaA;
            }
            set
            {
                if (vrstaA != value)
                {
                    vrstaA = value;
                }
            }
        }

        
        public float zapremnina
        {
            get
            {
                return zapremninaA;
            }
            set
            {
                if (zapremninaA != value)
                {
                    zapremninaA = value;
                }
            }
        }

        
        public int Spremi()
        {
            string sqlUpit = "";

            if (idAmbalaza == 0)       
            {
                sqlUpit = "INSERT INTO ambalaza (idAmbalaza, vrsta, zapremnina) "
                        + "VALUES (null, '" + vrsta + "','" + zapremnina + "')";
            }
            else                
            {
                sqlUpit = "UPDATE ambalaza SET vrsta = '" + vrsta
                + "', zapremnina = '" + zapremnina
                + "' WHERE idAmbalaza = " + idAmbalaza;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

      
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM ambalaza WHERE idAmbalaza = " + idAmbalaza;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

        
        public static List<vrstaAmbalaze> DohvatiAmbalazu()
        {
            List<vrstaAmbalaze> lista = new List<vrstaAmbalaze>();

            string sqlUpit = "SELECT * FROM ambalaza";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                vrstaAmbalaze ambalaza = new vrstaAmbalaze(dr);
                lista.Add(ambalaza);
            }
            dr.Close();
            return lista;
        }

        public override string ToString()
        {
            return vrsta;

        }

        
    }
}
