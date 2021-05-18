using System;
using System.Collections.Generic;

#nullable disable

namespace TravelCatalogue.Models
{
    public partial class Destination
    {
        public Destination()
        {
            Attractions = new HashSet<Attraction>();
            Traveltips = new HashSet<Traveltip>();
        }

        public short DestinationId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string ImageSilhoutte { get; set; }
        public string ImageFlag { get; set; }
        public string CoverImage { get; set; }

        public virtual ICollection<Attraction> Attractions { get; set; }
        public virtual ICollection<Traveltip> Traveltips { get; set; }
    }
}
