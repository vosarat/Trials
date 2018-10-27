using System;
using System.Collections.Generic;

namespace EFCoreWorksWithStoredProcedures
{
    public partial class Blogs
    {
        public Blogs()
        {
            Posts = new HashSet<Posts>();
        }

        public int Id { get; set; }
        public string Url { get; set; }

        public ICollection<Posts> Posts { get; set; }
    }
}
