using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediTracker.Models
{
    public class Symptom
    {
        [Key]
        public int SymptomId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public ApplicationUser user { get; set; }

    }
}
