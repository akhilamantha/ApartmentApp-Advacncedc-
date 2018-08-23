using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentSystem.DAL
{
    public class TenantDetails
    {
        public int Tenantid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SSN { get; set; }
        public int NumberOfFres { get; set; }
        public string ApartmentType { get; set; }
        public string IsPetsAvailable { get; set; }
    }
}
