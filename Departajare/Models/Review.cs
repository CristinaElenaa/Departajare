using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Departajare.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime DatePublished { get; set; }
        public string ReviewText { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
