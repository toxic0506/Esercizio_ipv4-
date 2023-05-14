using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipv4
{
    /// <summary>
    /// Creata una classe che mi va a calcolare indirizzo ipv4 e subnetmask a partire da 32bit 
    /// </summary>
    /// <item> Generatore di indirizzo ipv4</item>
    /// <item> Generatore di subnet mask</item>
    /// <param name="_bit"> stringa dei bit inseriti in entrata</param>
    /// <param name="_otteti">array di stringa</param>
    /// <param name="_cidr">Stringa del cidr inserito dall'utente</param>
    public class Calcolarore: IAddress
    {
        string _bitstringa;
        string[] _ottetto;
        string _cidr;
        public Calcolarore(string bits,string cidr)
        {
            _bitstringa = bits;
            _cidr = cidr;
        }
        public string generateIPv4()
        {
            string fine="";
            if (_bitstringa.Length != 32)
            {
                _ottetto = _bitstringa.Split('.');
                fine= $"{Convert.ToInt32(_ottetto[0], 2)}.{Convert.ToInt32(_ottetto[1],2)}.{Convert.ToInt32(_ottetto[2],2)}.{Convert.ToInt32(_ottetto[3],2)}";
                return fine;
            }
            else
                throw new Exception("errati ");
        }

        public string generateSubnet()
        {
            if (!int.TryParse(_cidr, out int  cidr_int))
                throw new ArgumentException("Errore il cidr è sbagliato");
            if (cidr_int < 0 || cidr_int> 32)
                throw new ArgumentException("Errore.Il cidr è sbagliato");

            string subnetMask = "";
            for (int i = 0; i < 4; i++)
            {
                if (cidr_int >= 8)
                {
                    subnetMask += "255";
                    cidr_int -= 8;
                }
                else if (cidr_int > 0)
                {
                    int otetto = 0;
                    for (int j = 0; j < cidr_int; j++)
                    {
                        otetto |= 1 << (7 - j);
                    }
                    subnetMask += otetto.ToString();
                   cidr_int = 0;
                }
                else
                {
                    subnetMask += "0";
                }

                if (i < 3)
                    subnetMask += ".";
            }

            return subnetMask;
        }

        }
    }

