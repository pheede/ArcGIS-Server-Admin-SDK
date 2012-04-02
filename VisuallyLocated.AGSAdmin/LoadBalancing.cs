﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VisuallyLocated.ArcGIS.Server
{
    [JsonConverter(typeof(UpperCaseStringEnumConverter))]
    public enum LoadBalancing
    {
        Round_Robin,
        Fail_Over
    }
}
