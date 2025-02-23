using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesLibrary
{
   public class Seen
    {
        public int SeenId { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public DateTime SeenDate { get; set; }
        public int IsFav { get; set; }
    }
}
