using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitecProjektTemplate.Models
{
    public class Subscriptions
    {
        public string SubscriptionType { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
