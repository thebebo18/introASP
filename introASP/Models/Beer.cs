﻿using System;
using System.Collections.Generic;

namespace introASP.Models
{
    public partial class Beer
    {
        public int BeerId { get; set; }
        public string? Name { get; set; }
        public int? BrandId { get; set; }
    }
}
