using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebApp
{
    public class JobInfo
    {

        [Key]
        public int jobID { get; set; }

        [Required]

        public string jobTitle { get; set; }

        public string employeerLogo { get; set; }

        public string employeer { get; set; }

        public string jobDescriptions { get; set; }

        public string requirements { get; set; }

        public string views { get; set; }

        public DateTime deadline { get; set; }


    }
}
