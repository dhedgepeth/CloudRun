using Umbraco.Cms.Core.Composing;

namespace CloudRunTest.Web
{
    public class DisableNuCacheDatabaseComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            var settings = new Umbraco.Cms.Infrastructure.PublishedCache.PublishedSnapshotServiceOptions
            {
                IgnoreLocalDb = true
            };
            builder.Services.AddSingleton(settings);
        }
    }
}