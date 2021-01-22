using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Wlays.Channels;

namespace Wlays.Web.Controllers
{
    public class ChannelController : WlaysControllerBase
    {

        protected readonly IChannelService _channelService;

        public ChannelController(IChannelService channelService)
        {
            _channelService = channelService;
        }
        // GET: Channel
        public async Task<ActionResult> Index()
        {
            var req = new Channels.Dto.ChannelDto()
            {
                Name = "首页",
                Description = "站点起始页面"
            };
            await _channelService.InsertChannel(req);
            return View();
        }
    }
}