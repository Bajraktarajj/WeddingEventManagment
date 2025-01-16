using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeedingEventManagment_WebApp.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Preferences { get; set; }

        public void MakePayment(double amount)
        {
            
            Console.WriteLine($"Payment of {amount} completed successfully.");
        }

        public void ViewWedding()
        {
          
            Console.WriteLine("Viewing wedding details...");
        }
    }
}

