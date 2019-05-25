using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAutoFac.Services
{
    public class Service2 :Service1,IService2
    {
        public int GetUserAge()
        {
            return 18;
        }
    }
}
