using Fluid;
using Microsoft.Extensions.DependencyInjection;
using Etch.OrchardCore.Fields.Values.Drivers;
using Etch.OrchardCore.Fields.Values.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Modules;

namespace Etch.OrchardCore.Fields.Values
{
    [Feature("Etch.OrchardCore.Fields.Values")]
    public class Startup : StartupBase
    {
        public Startup()
        {
            TemplateContext.GlobalMemberAccessStrategy.Register<ValuesField>();
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ContentField, ValuesField>();

            services.AddScoped<IContentFieldDisplayDriver, ValuesFieldDisplayDriver>();
        }
    }
}
