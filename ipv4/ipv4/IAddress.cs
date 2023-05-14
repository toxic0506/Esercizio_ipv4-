using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipv4
{
    /// <summary>
    /// Inizializzazione di un'interfaccia a due metodi con ritorno stringa
    /// </summary>
    ///<item> Generatore di indirizzo ipv4</item>
    ///<item>Generatore di subnet mask</item>
    public interface IAddress
    {
        string generateIPv4();
        string generateSubnet();
    }
}
