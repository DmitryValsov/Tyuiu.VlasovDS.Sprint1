﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VlasovDS.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int res = Convert.ToInt32((x - Math.Truncate(x)) * 10);
            if (res >= 5)
            {
                res = res - 1;
                return res;
            }
            else
            {
                return res;
            }
        }
    }
}
