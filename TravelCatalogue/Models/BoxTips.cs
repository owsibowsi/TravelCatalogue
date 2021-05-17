using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCatalogue.Models
{
    public class BoxTips
    {
        public string Title { get; set; }
        public string Food { get; set; }
        public string Culture { get; set; }
        public string Transport { get; set; }
        public string ImageFileName { get; set; }

        // Cons
        public BoxTips() { }

        public BoxTips(string title, string food, string culture, string transport)
        {
            Title = title;
            Food = food;
            Culture = culture;
            Transport = transport;
        }
    }

   


}
