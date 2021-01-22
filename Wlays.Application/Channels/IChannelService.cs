using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlays.Channels
{
    public interface IChannelService
    {
        Task<int> InsertChannel(Dto.ChannelDto input);

        Task<Channels.Channel> GetChannel(int id);
    }
}
