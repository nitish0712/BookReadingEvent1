using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookReadingEvent1.Models
{
    public class CommentModel
    {
        [Required]
        public string CommentAdded { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime Date { get; set; }

        [Required]
        public int EventId { get; set; }
    }
}