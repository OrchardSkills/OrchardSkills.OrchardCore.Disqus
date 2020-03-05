using OrchardCore.Disqus.Drivers;
using OrchardCore.Disqus.Handlers;
using OrchardCore.Disqus.Models;
using OrchardCore.Disqus.Settings;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;

namespace OrchardCore.Disqus
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddContentPart<DisqusPart>(); 
            services.AddScoped<IContentPartDisplayDriver, DisqusPartDisplayDriver>();
            services.AddScoped<IContentTypePartDefinitionDisplayDriver, DisqusPartSettingsDisplayDriver>();
            services.AddScoped<IDataMigration, Migrations>();
            services.AddScoped<IContentPartHandler, DisqusPartHandler>();
        }
    }
}