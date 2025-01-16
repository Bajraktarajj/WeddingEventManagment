using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeedingEventManagment_WebApp.Models
{
    public class Photography
    {
        public int PhotographyID { get; set; }
        public string PackageType { get; set; }
        public double Price { get; set; }
        public string PhotographerName { get; set; }

        public string GetDetails()
        {
            return $"Photography Package: {PackageType}, Photographer: {PhotographerName}, Price: {Price}";
        }
    }
}
