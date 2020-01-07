using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediTracker.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string ImgName { get; set; }

        [Required]
        public int EntryId { get; set; }
        public Entry Entry { get; set; }
    }
}
