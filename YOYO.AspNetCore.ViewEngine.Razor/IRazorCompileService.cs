﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YOYO.AspNetCore.ViewEngine.Razor
{
    public interface IRazorCompileService
    {

        Type Compile(string code);
        
    }
}
