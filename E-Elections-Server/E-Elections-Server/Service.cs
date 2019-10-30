using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Elections_Server
{
    public class Service : IService
    {
        public USER DoLogin(string user, string pass)
        {
            try
            {
                USER data = new USER();
                    data.username = user;
                    data.password = pass;
                    data.firstname = "ecco";
                    data.lastname = "suprastyo";
          
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
