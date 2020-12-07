using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnimalCrossingWebApp.Data.Entities
{
    public class Villagers
    {
        [Key]
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
