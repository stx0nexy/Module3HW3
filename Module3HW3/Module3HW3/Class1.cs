﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class Class1
    {
        public Action<bool> DelegateShow { get; set; }

        public int Pow(int x, int y) => x * y;
    }
}
