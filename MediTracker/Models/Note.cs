using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediTracker.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        [Required]
        public int AppointmentId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Date { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
