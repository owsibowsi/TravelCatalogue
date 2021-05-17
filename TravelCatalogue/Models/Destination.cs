using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCatalogue.Models
{
    public class Destination
    {
        private string Country { get; set; }
        private string City { get; set; }
        private string Description { get; set; }
        public string imageSilhoutte { get; set; }
        public string imageFlag { get; set; }

        private List<string> inspirationImages { get; } = new List<string>();
        private List<Attraction> attractions { get; } = new List<Attraction>();

        private List<TravelTip> travelTips { get; set; } = new List<TravelTip>();

    }
}
