using System;
using System.Collections.Generic;

#nullable disable

namespace TravelCatalogue.Models
{
    public partial class Attraction
    {
        public short AttractionId { get; set; }
        public string AttractionName { get; set; }
        public string AttractionDescription { get; set; }
        public string AttractionImage { get; set; }
        public short? DestinationId { get; set; }

        public virtual Destination Destination { get; set; }
    }
}
