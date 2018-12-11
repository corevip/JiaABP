using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JiaABP.MultiTenancy.Dto;

namespace JiaABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
