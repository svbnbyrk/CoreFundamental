﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFundamental.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CousinType Cousin { get; set; }
    }
}
