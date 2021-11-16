﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace You.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        [JsonProperty("f_name")]
        public string Firstname { get; set; }
        [JsonProperty("l_name")]
        public string Lastname { get; set; }
    }
}
