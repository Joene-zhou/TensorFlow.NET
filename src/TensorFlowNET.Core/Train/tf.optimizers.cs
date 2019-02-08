﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tensorflow
{
    public static partial class tf
    {
        public static class train
        {
            public static Optimizer GradientDescentOptimizer(double learning_rate) => new GradientDescentOptimizer(learning_rate);

            public static Saver Saver() => new Saver();
        }
    }
}
