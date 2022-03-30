using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleProxy
{
    public class RealInternet : Internet
    {

    public void connectTo(String serverhost)
        {
            Console.WriteLine("Connecting to " + serverhost);
        }
    }
}
