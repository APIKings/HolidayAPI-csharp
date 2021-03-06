﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace APIKings.Holiday.Responses
{
    public class ResponseFuturePast : IAPIResponse
    {
        public bool Success { get; set; }
        public List<Holiday> Holidays { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }   
}
