using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediTracker.Models
{
    public class Entry
    {
        [Key]
        public int EntryId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Notes { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public virtual ICollection<EntrySymptom> EntrySymptoms { get; set; }
        
        [NotMapped]
        public int NumOfSymptoms {
            get
            {
                if (EntrySymptoms != null)
                {
                    return EntrySymptoms.Count();
                }
                else return 0;
            }
        }

        [NotMapped]
        public string dateString { get  
            {
                return Date.ToLongDateString();
            } 
        }

        [NotMapped]
        public List<Image> Images { get; set; }
    }
}
