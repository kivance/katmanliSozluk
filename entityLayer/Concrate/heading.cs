using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.Concrate
{
    public class heading
    {
        public int HeadingID { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; }
        public virtual category Category { get; set; }

        public ICollection<content> Contents { get; set; }
        public int AuthorID { get; set; }
        public virtual author Author { get; set; }
    }
}
