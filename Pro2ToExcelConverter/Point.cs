﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2ToExcelConverter
{
    class Point
    {
        public Double TemperatureOrPressure;
        public Double Fraction;

        public Point(Double Fraction, Double TemperatureOrPressure)
        {
            this.TemperatureOrPressure = TemperatureOrPressure;
            this.Fraction = Fraction;
        }

    }
}
