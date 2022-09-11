using System;
using System.ComponentModel.DataAnnotations;

namespace PucarsServices.Models
{
    public class BoardMeetingFinancialResults
    {
        [Key]
        public uint BoardMeetingFinancialResultsId { get; set; }
        [Required]
        public DateOnly HeldDate { get; set; }
        [Required]
        public TimeOnly HeldTime { get; set; }
        [Required]
        public string HeldPalce { get; set; }
        [Required]
        public DateOnly ClosedForm { get; set; }
        [Required]
        public DateOnly ClosedTo { get; set; }
        [Required]
        public string MeetingAgenda { get; set; }
    }
}
