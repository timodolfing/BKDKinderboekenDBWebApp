using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BKDKinderboekenDBWebApp.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Boek
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Samenvatting { get; set; }
        public int Cijfer { get; set; }
    }
  
}