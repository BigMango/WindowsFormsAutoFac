using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAutoFac.Services
{
    public class Service1 : IService1
    {
        private string _userName = "Mango";
        public virtual string GetUserName()
        {
            return _userName;
        }

        public void SetUserName(string userName)
        {
            _userName = userName;
        }
    }
}
