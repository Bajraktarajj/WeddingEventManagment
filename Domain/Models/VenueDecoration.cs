using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeedingEventManagment_WebApp.Models
{
    public class VenueDecoration
    {
        public int DecorationID { get; set; }
        public string Theme { get; set; }
        public double Budget { get; set; }

        public string GetDetails()
        {
            return $"Decoration Theme: {Theme}, Budget: {Budget}";
        }
    }
}

