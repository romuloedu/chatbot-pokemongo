using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.Extensions.Logging;

namespace ChatBot.PokemonGo.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class BotController : ControllerBase
    {
        private readonly ILogger<BotController> _logger;
        private readonly IBotFrameworkHttpAdapter _adapter;
        private readonly IBot _bot;

        public BotController(ILogger<BotController> logger, IBotFrameworkHttpAdapter adapter,
         IBot bot)
        {
            _logger = logger;
            _adapter = adapter;
            _bot = bot;
        }

        [HttpPost, HttpGet]
        public async Task Post()
        {
            await _adapter.ProcessAsync(Request, Response, _bot);
        }
    }
}
