using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediTracker.Models
{
    public class EntrySymptom
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EntryId { get; set; }
        public Entry Entry { get; set; }

        [Required]
        public int SymptomId { get; set; }
        public Symptom Symptom { get; set; }

    }
}
