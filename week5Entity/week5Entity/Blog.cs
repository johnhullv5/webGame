using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Entity
{
    class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
    public virtual List<Post> posts { get; set; }
    }
}
