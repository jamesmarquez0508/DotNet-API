﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace NetStone.Definitions
{
    public class DefinitionsPack
    {
        [JsonProperty("selector")] public string Selector { get; set; }
        
        [JsonProperty("regex")] public string PerlBasedRegex { get; set; }

        public string Regex => PerlBasedRegex.Replace("(?P<", "(?<", StringComparison.InvariantCulture);

        [JsonProperty("or")] public string Description { get; set; }
    }
}
