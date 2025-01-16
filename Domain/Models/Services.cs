using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeedingEventManagment_WebApp.Models
{
    public class Services
    {
        public int ServicesID { get; set; }
        public string ServiceName { get; set; }
        public double ServicePrice { get; set; }

        public string GetDetails()
        {
            return $"Service: {ServiceName}, Price: {ServicePrice}";
        }
    }
}

