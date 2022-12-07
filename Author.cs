using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary.Models
{
    internal class Author
    {
        public int authorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime  birthDate{ get; set; }
        public string comment { get; set; }
    }
}
