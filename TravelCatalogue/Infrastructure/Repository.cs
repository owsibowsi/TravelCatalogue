using TravelCatalogue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCatalogue.Infrastructure
{
    public static class Repository
    {
        public static List<BoxTips> BoxTips = new List<BoxTips>();

        static Repository()
        {
            var India = new BoxTips("India", "Chicken Tikka Masala", "Women should be ready to cover themselves in certain areas", "Scooters and busses are the most common form of transport");
            var Japan = new BoxTips("India", "Chicken Tikka Masala", "Women should be ready to cover themselves in certain areas", "Scooters and busses are the most common form of transport");

        }
    }
}

// string title, string food, string culture, string transport, string imageFileName