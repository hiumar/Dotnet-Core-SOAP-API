using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PucarsServices.Models
{
    [DataContract]
    public class GetAllBoardMeetings
    {

        //public uint BoardMeetingId {get;set;}

        //public DateOnly HeldDate { get; set; }

        //public TimeOnly HeldTime { get; set;}
        [DataMember]
        public string HeldPalce { get; set; }

        //public DateOnly PeriodEnded { get; set; }
        [DataMember]
        public DateOnly ClosedForm { get; set; }

        //[DataMember]
        //public DateOnly ClosedTo { get; set; }
        [DataMember]
        public string AccountsEnded { get; set; }
    }
}
