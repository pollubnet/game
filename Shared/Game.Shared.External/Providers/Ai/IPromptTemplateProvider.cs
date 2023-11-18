﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Shared.External.Providers.Ai
{
    public interface IPromptTemplateProvider
    {
        string GetPrompt(PromptTemplate template);
    }
}
