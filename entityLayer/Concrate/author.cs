using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.Concrate
{
    public class author
    {

        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorMail { get; set; }
        public string AuthorPassword { get; set; }


        public ICollection<heading> Headings { get; set; }

        public ICollection<content>  Contents { get; set; }

    }
}
