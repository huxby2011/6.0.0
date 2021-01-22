using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlays.Channels
{
    /// <summary>
    /// 栏目仓储
    /// </summary>
    public interface IChannelRepository : IRepository<Channel>
    {
    }
}
