using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ICUapp.Shared
{
    public class Participant
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }

        public string? MiddleName { get; set; }
        
        public int GenderId { get; set; }

        [Required(ErrorMessage = "Required")]
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }

        public string? Organisation  { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Required")]
        public DateTime ArrivalTime { get; set; }
    }
}
