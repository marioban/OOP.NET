﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Team
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }


        public override string ToString() => Country + " " + "(" + FifaCode + ")";
    }
}
