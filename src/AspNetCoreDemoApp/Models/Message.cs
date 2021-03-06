﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AspNetCoreDemoApp.Models
{    
    public class Message
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("type")]
        public MessageType Type { get; set; }
    }
}
