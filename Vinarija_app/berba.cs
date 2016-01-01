using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class berba
    {
        public berba() 
        {
        }

        
        public berba(DbDataReader dr)
        {
            if (dr != null)
            {
                idBerbe = int.Parse(dr["idBerbe"].ToString());
                datum = dr["datum"].ToString();
                kolicina = float.Parse(dr["kolicina"].ToString());
                idVinogradSorte = int.Parse(dr["idVinogradSorte"].ToString());
            }
        }

        private int id;
        private string datumB;
        private float kolicinaB;
        private int idVinogradSorteB;
        

        public int idBerbe
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
                return datumB;
            }
            set
            {
                if (datumB != value)
                {
                    datumB = value;
                }
            }
        }

        
        public float kolicina
        {
            get
            {
                return kolicinaB;
            }
            set
            {
                if (kolicinaB != value)
                {
                    kolicinaB = value;
                }
            }
        }

        public int idVinogradSorte
        {
            get
            {
                return idVinogradSorteB;
            }
            set
            {
                if (idVinogradSorteB != value)
                {
                    idVinogradSorteB = value;
                }
            }
        }

        
        public int Spremi()
        {
            string sqlUpit = "";

            if (idBerbe == 0)        //Ako se radi o novokreiranom timu tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO berba (idBerbe, datum, kolicina, idVinogradSorte) "
                        + "VALUES (null, '" + datum + "','" + kolicina + "','" + idVinogradSorte + "')";
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE berba SET datum = '" + datum
                + "', kolicina = '" + kolicina
                + "', idVinogradSorte = '" + idVinogradSorte
                + "' WHERE idBerbe = " + idBerbe;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

       
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM berba WHERE idBerbe = " + idBerbe;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

      
        public static List<berba> DohvatiBerbu()
        {
            List<berba> lista = new List<berba>();

            string sqlUpit = "SELECT * FROM berba";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                berba berbe = new berba(dr);
                lista.Add(berbe);
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
