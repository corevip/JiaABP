using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using JiaABP.MultiTenancy;

namespace JiaABP.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
