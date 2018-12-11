using System.Threading.Tasks;
using JiaABP.Configuration.Dto;

namespace JiaABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
