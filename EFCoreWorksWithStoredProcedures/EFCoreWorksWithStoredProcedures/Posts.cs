﻿using System;
using System.Collections.Generic;

namespace EFCoreWorksWithStoredProcedures
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public Blogs Blog { get; set; }
    }
}
