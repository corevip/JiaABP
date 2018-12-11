using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JiaABP.Roles.Dto;
using JiaABP.Users.Dto;

namespace JiaABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
