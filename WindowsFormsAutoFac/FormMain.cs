using System;
using System.Collections.Generic;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


            var builder = new ContainerBuilder();

            //register pure class
            builder.RegisterType<ServicePureClass>();
            builder.RegisterType<Service1>().As<IService1>().SingleInstance();
            builder.RegisterType<Service2>().As<IService2>().InstancePerLifetimeScope();
            container = builder.Build();
            AutoFacGolbal.Container = container;
;        }


        private IContainer container;

        private void BtnService1_Click(object sender, EventArgs e)
        {
            var service = container.Resolve<IService1>();
            edtService1UserName.Text = service.GetUserName();
        }

        private void BtnService2_Click(object sender, EventArgs e)
        {
            using (ILifetimeScope lifetimeScope = container.BeginLifetimeScope())
            {
                IService2 service = null;
                for (int i = 0; i < 3; i++)
                {
                    service = lifetimeScope.Resolve<IService2>();
                    service.SetUserName(service.GetUserName() + ".");
                }
                MessageBox.Show(service.GetUserName());
            }
        }

        private void BtnServicePureClass_Click(object sender, EventArgs e)
        {
            var service = container.Resolve<ServicePureClass>();

        }

        private void BtnService1SetUserName_Click(object sender, EventArgs e)
        {
            var service = container.Resolve<IService1>();
            service.SetUserName(edtService1UserName.Text);
        }

        private void BtnSecondForms_Click(object sender, EventArgs e)
        {
            FormSecond formSecond = new FormSecond();
            formSecond.ShowDialog();
        }
    }
}
