using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;

namespace E_Elections_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost hostWeb = new WebServiceHost(typeof(E_Elections_Server.Service));
            ServiceEndpoint ep = hostWeb.AddServiceEndpoint(typeof(E_Elections_Server.IService), new WebHttpBinding(), "");
            ServiceDebugBehavior stp = hostWeb.Description.Behaviors.Find<ServiceDebugBehavior>();
            stp.HttpHelpPageEnabled = false;
            hostWeb.Open();
            Console.WriteLine("Service Host started @ " + DateTime.Now.ToString());
            Console.Read();
        }
    }
}
