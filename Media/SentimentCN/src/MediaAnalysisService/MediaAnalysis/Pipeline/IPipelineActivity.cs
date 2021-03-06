﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAnalysis.Pipeline
{
    public interface IPipelineActivity
    {

        string Name { get; set; }

        ActivityResult Run(PipelineContext context);
    }
}
