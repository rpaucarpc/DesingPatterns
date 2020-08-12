﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa1
{
    public class Director
    {
        IBuilder builder;
        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadLights();
            builder.EndOperations();
        }
    }
}
