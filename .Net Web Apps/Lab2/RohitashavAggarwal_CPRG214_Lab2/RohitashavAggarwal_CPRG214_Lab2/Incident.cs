using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RohitashavAggarwal_CPRG214_Lab2
{
    public class Incident
    {
        public int IncidentID { get; set; }
        public int CustomerID { get; set; }
        public string ProductCode { get; set; }
        public int? TechnicianID { get; set; }
        public DateTime DateOpen { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
        public DateTime? DateClose 
        { get; set; }
        
        
    }
}