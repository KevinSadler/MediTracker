using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediTracker.Models.ViewModels
{
    public class EntryImageVM
    {
        public int EntryId { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
