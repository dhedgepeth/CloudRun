using Umbraco.Cms.Core.Sync;

namespace CloudRunTest.Web.ServerRoleAccessors
{
    public sealed class SubscriberServerRoleAccessor : IServerRoleAccessor
    {
        public ServerRole CurrentServerRole => ServerRole.Subscriber;
    }
}
