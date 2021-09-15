using BookReadingEvent1.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Models
{
    public class EventModel
    {
        public string UserId { get; set; }

        public int EventId { get; set; }

        [Display(Name="Title")]
        [Required]
        public string Title { get; set; }

        [Display(Name ="Date")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name ="Location")]
        [Required]
        public string Location { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }


        [Required]
        public EventType Type { get; set; }

        [Display(Name ="Duration in Hours")]
        [Range(0,5)]
        public int? Duration { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [Display(Name ="Other Details")]
        [MaxLength(500)]
        public string OtherDetails { get; set; }


        [Display(Name ="Invite Others")]
        public string InviteByEmail { get; set; }


        public int Count { get; set; }


        public string CommentAdded { get; set; }

    }
}