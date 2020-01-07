using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediTracker.Models
{
    public class Medication
    {
        [Key]
        public int MedicationId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Dosage { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
