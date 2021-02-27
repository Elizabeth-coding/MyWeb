using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class Geekration
    {
        public int Id { get; set; }
        [Required]
        public string Passions { get; set; }
        [Required]
        public string Hobbies { get; set; }
        [Required]
        public string Your_Values { get; set; }
        [Required]
        public string Change { get; set; }
        [Required]
        public string MyLife { get; set; }
        [Required]
        public string geeky1 { get; set; }
        [Required]
        public string geeky2 { get; set; }

    }
}
