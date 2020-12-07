using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCrossingWebApp.Common.Models
{
    public class VillagersDto
    {
        public int newID { get; set; }
        public string Name { get; set; }
        public string Personality { get; set; }
        public string Species { get; set; }
        public string DateOfBirth { get; set; }
        public string Catchphrase { get; set; }
        public string PicURL { get; set; }

        public string Hobby { get; set; }
        public string Color { get; set; }
        public string Styles { get; set; }
        public string House { get; set; }
    }
}
