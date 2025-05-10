// Models/EventModel.cs
using System.ComponentModel.DataAnnotations;

namespace EventEase_Blazor.Models;

 public class EventModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Event name is required")]
        public string Name { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }
        
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;
        
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }