using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Wlays.Channels.Dto
{
    [AutoMap(typeof(Channel))]
    public class ChannelDto : EntityDto
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
