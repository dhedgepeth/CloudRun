using Umbraco.Cms.Core.Sync;

namespace CloudRunTest.Web.ServerRoleAccessors
{
    public sealed class SingleServerRoleAccessor : IServerRoleAccessor
    {
        public ServerRole CurrentServerRole => ServerRole.Single;
    }

}