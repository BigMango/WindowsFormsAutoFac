using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAutoFac.Services
{
    public interface IService1
    {
        string GetUserName();
        void SetUserName(string userName);
    }
}
