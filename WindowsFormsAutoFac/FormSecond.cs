using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAutoFac.Services;
using Autofac;

namespace WindowsFormsAutoFac
{
    public partial class FormSecond : Form
    {
        public FormSecond()
        {
            InitializeComponent();
        }

        private void BtnService1_Click(object sender, EventArgs e)
        {
            var service = AutoFacGolbal.Container.Resolve<IService1>();
            MessageBox.Show(service.GetUserName());
        }
    }
}
