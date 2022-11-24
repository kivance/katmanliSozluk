using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.Concrate
{
    public class content
    {
        public int ContentID { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; }
        public virtual heading Heading { get; set; }

        public int? AuthorID { get; set; } // ? boş olabilir demek!!
        public virtual author Author { get; set; }
    }
}
