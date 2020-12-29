using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string What_Are_You_Passionate_About { get; set; }

        public string What_To_Do { get; set; }
        public string Who_Are_You_Making_This_For { get; set; }
        public string Why_Did_You_Decide_To_Create_This_Website_or_App { get; set; }
    }
}
