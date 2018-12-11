using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using JiaABP.Configuration;
using JiaABP.Web;

namespace JiaABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class JiaABPDbContextFactory : IDesignTimeDbContextFactory<JiaABPDbContext>
    {
        public JiaABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<JiaABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            JiaABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(JiaABPConsts.ConnectionStringName));

            return new JiaABPDbContext(builder.Options);
        }
    }
}
