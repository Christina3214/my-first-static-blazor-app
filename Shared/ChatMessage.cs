﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class ChatMessage
    {
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
