﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Preparation
{
    class Gpu : Product
    {
        public Gpu(double price)
           : base(price)
        {
            this.Weight = 0.7;
        }
    }
}
