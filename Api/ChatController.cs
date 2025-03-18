using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Graph;
using BlazorApp.Shared;

namespace Api
{
    [ApiController]
    [Route("api/[controller]")]
    internal class ChatController : ControllerBase
    {
        private static List<ChatMessage> messages = new List<ChatMessage>();
        [HttpGet]
        public IEnumerable<ChatMessage> GetMessages()
        {
            return messages.OrderBy(m => m.Timestamp);
        }
        [HttpPost]
        public IActionResult PostMessage(ChatMessage message)
        {
            message.Timestamp = DateTime.Now;
            messages.Add(message);
            return Ok();
        }
        
    }
}
