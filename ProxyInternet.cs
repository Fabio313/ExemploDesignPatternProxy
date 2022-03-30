using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleProxy
{
    public class ProxyInternet : Internet
    {
        private RealInternet internet = new RealInternet();
        private static List<string> sitesbanidos;

        public ProxyInternet()
        {
            sitesbanidos = new List<String>();
            sitesbanidos.Add("abc.com");
            sitesbanidos.Add("def.com");
            sitesbanidos.Add("ijk.com");
            sitesbanidos.Add("lnm.com");
        }

        public void connectTo(String serverhost)
        {
            if (sitesbanidos.Contains(serverhost.ToLower()))
            {
                throw new Exception("Access Denied");
            }
            internet.connectTo(serverhost);
        }

    }
}
