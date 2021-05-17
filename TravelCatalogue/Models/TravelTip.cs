using System;
using System.Collections.Generic;

#nullable disable

namespace TravelCatalogue.Models
{
    public partial class Traveltip
    {
        public short TraveltipId { get; set; }
        public string TraveltipName { get; set; }
        public string TraveltipDescription { get; set; }
        public string TraveltipImage { get; set; }
        public short? DestinationId { get; set; }

        public virtual Destination Destination { get; set; }
    }
}
