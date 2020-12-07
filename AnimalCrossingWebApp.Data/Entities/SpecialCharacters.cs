using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnimalCrossingWebApp.Data.Entities
{
    public class SpecialCharacters
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Service { get; set; }


    }
}
