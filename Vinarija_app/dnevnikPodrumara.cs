using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinarija_app
{
    public class dnevnikPodrumara
    {
        public dnevnikPodrumara() 
        {
        }

        public dnevnikPodrumara(DbDataReader dr)
        {
            if (dr != null)
            {
                idDnevnikP = int.Parse(dr["idDnevnikP"].ToString());
                datum = dr["datum"].ToString();
                idVino = int.Parse(dr["idVino"].ToString()); 
                aktivnosti = dr["aktivnosti"].ToString();
                temperatura = float.Parse(dr["temperatura"].ToString());
                alkohol = float.Parse(dr["alkohol"].ToString());
                secer = float.Parse(dr["secer"].ToString());
                pH = float.Parse(dr["pH"].ToString());
                ukupnaKiselost = float.Parse(dr["ukupnaKiselost"].ToString());
                hlapivaKiselost = float.Parse(dr["hlapivaKiselost"].ToString());
                slobodniSO2 = float.Parse(dr["slobodniSO2"].ToString());
                ukupniSO2 = float.Parse(dr["ukupniSO2"].ToString());
  
            }
        }


        private int idDnevnik;
        private string datumP;
        private int idVinoP;
        private string aktivnostiP;
        private float temperaturaP;
        private float alkoholP;
        private float secerP;
        private float pHP;
        private float ukupnaKiselostP;
        private float hlapivaKiselostP;
        private float slobodniSO2P;
        private float ukupniSO2P;

        public int idDnevnikP
        {
            get
            {
                return idDnevnik;
            }
            set
            {
                if (idDnevnik != value)
                {
                    idDnevnik = value;
                }
            }
        }

        
        public string datum
        {
            get
            {
                return datumP;
            }
            set
            {
                if (datumP != value)
                {
                    datumP = value;
                }
            }
        }

        public int idVino
        {
            get
            {
                return idVinoP;
            }
            set
            {
                if (idVinoP != value)
                {
                    idVinoP = value;
                }
            }
        }
        
        public string aktivnosti
        {
            get
            {
                return aktivnostiP;
            }
            set
            {
                if (aktivnostiP != value)
                {
                    aktivnostiP = value;
                }
            }
        }

        public float temperatura
        {
            get
            {
                return temperaturaP;
            }
            set
            {
                if (temperaturaP != value)
                {
                    temperaturaP = value;
                }
            }
        }

        public float alkohol
        {
            get
            {
                return alkoholP;
            }
            set
            {
                if (alkoholP != value)
                {
                    alkoholP = value;
                }
            }
        }

        public float secer
        {
            get
            {
                return secerP;
            }
            set
            {
                if (secerP != value)
                {
                    secerP = value;
                }
            }
        }

        public float pH
        {
            get
            {
                return pHP;
            }
            set
            {
                if (pHP != value)
                {
                    pHP = value;
                }
            }
        }

        public float ukupnaKiselost
        {
            get
            {
                return ukupnaKiselostP;
            }
            set
            {
                if (ukupnaKiselostP != value)
                {
                    ukupnaKiselostP = value;
                }
            }
        }

        public float hlapivaKiselost
        {
            get
            {
                return hlapivaKiselostP;
            }
            set
            {
                if (hlapivaKiselostP != value)
                {
                    hlapivaKiselostP = value;
                }
            }
        }

        public float slobodniSO2
        {
            get
            {
                return slobodniSO2P;
            }
            set
            {
                if (slobodniSO2P != value)
                {
                    slobodniSO2P = value;
                }
            }
        }

        public float ukupniSO2
        {
            get
            {
                return ukupniSO2P;
            }
            set
            {
                if (ukupniSO2P != value)
                {
                    ukupniSO2P = value;
                }
            }
        }


        public int Spremi()
        {
            string sqlUpit = "";

            if (idDnevnikP == 0)       
            {
                sqlUpit = "INSERT INTO dnevnikPodrumara (idDnevnikP, datum, idVino, aktivnosti, temperatura, alkohol, secer, pH, ukupnaKiselost, hlapivaKiselost, slobodniSO2, ukupniSO2) "
                        + "VALUES (null, '" + datum + "','" + idVino + "','" + aktivnosti + "','" + temperatura + "','" + alkohol + "','" + secer + "','" + pH + "','" + ukupnaKiselost + "','" + hlapivaKiselost + "','" + slobodniSO2 + "','" + ukupniSO2 + "')";
            }
            else              
            {
                sqlUpit = "UPDATE dnevnikPodrumara SET datum = '" + datum
                + "', idVino = '" + idVino
                + "', aktivnosti = '" + aktivnosti
                + "', temperatura = '" + temperatura
                + "', alkohol = '" + alkohol
                + "', secer = '" + secer
                + "', pH = '" + pH
                + "', ukupnaKiselost = '" + ukupnaKiselost
                + "', hlapivaKiselost = '" + hlapivaKiselost
                + "', slobodniSO2 = '" + slobodniSO2
                + "', ukupniSO2 = '" + ukupniSO2
                + "' WHERE idDnevnikP = " + idDnevnikP;

            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM dnevnikPodrumara WHERE idDnevnikP = " + idDnevnikP;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }



        public static List<dnevnikPodrumara> DohvatiDnevnikP()
        {
            List<dnevnikPodrumara> lista = new List<dnevnikPodrumara>();

            string sqlUpit = "SELECT * FROM dnevnikPodrumara";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                dnevnikPodrumara dnevnikPodrumara = new dnevnikPodrumara(dr);
                lista.Add(dnevnikPodrumara);
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
