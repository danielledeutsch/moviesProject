using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesLibrary
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int RatingValue { get; set; }
        public string? Review { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
