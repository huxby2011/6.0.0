using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wlays.Channels.Dto;

namespace Wlays.Channels
{
    public class ChannelService : WlaysAppServiceBase, IChannelService
    {
        private readonly IRepository<Channel> _channelRepository;

        public ChannelService(IRepository<Channel> channelRepository)
        {
            _channelRepository = channelRepository;
        }

        public async Task<Channel> GetChannel(int id)
        {
            var res = await _channelRepository.GetAsync(id);

            return res;
        }


        public async Task<int> InsertChannel(ChannelDto input)
        {
            //  var chaneel = ObjectMapper.Map<Channel>(input);
            var channel = new Channel()
            {
                Name = input.Name,
                Description = input.Description
            };

            var res = await _channelRepository.InsertOrUpdateAndGetIdAsync(channel);

            return res;
        }
    }
}
