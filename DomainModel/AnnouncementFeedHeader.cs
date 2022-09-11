using System;
using System.ComponentModel.DataAnnotations;

namespace PUCARS.API.DomainModel
{
    public class AnnouncementFeedHeader
    {
        [Required]
        public string AnnouncementAction { get; set; }
        [Required]
        public string AnnouncementType { get; set; }
        [Required]
        public string AnnouncementId { get; set; }
        [Required]
        public string SymbolCode { get; set; }
        [Required]
        public string AnnouncementTitle { get; set; }
        [Required]
        public DateOnly PostingDate { get; set; }
        [Required]
        public TimeOnly PostingTime { get; set; }
        [Required]
        public DateTime ActionTimestamp { get; set; }
        public string Enclosure { get; set; }
        [Required]
        public string Revised { get; set; }
        public string OriginalAnnouncementId { get; set; }
        [Required]
        public string Attachment { get; set; }
    }
}
