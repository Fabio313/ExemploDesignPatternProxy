using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleProxy
{
    public interface Internet
    {
        public void connectTo(String serverhost)
        {
            throw new NotImplementedException();
        }
    }
}
