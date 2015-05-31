﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbqf.Configuration;

namespace Standalone.Core
{
    public interface IApplication
    {
        ISubject SelectedSubject { get; set; }
        string ApplicationTitle { get; }
        string ResultSQL { get; set; }

        void Export(string filename);
    }
}