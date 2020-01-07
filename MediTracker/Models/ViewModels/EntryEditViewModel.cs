using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediTracker.Models.ViewModels
{
    public class EntryEditViewModel
    {
        public Entry Entry { get; set; }
        public List<Symptom> AllSymptoms { get; set; } = new List<Symptom>();
        public List<int> SelectedSymptomIds { get; set; } = new List<int>();
        public List<SelectListItem> SymptomOptions
        {
            get
            {
                if (AllSymptoms == null) return null;

                return AllSymptoms
                    .Select(s => new SelectListItem($"{s.Title} )", s.SymptomId.ToString()))
                    .ToList();
            }
        }
    }
}
