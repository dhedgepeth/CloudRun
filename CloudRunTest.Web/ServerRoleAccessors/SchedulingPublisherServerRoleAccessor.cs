﻿using Umbraco.Cms.Core.Sync;

namespace CloudRunTest.Web.ServerRoleAccessors
{
    public sealed class SchedulingPublisherServerRoleAccessor : IServerRoleAccessor
    {
        public ServerRole CurrentServerRole => ServerRole.SchedulingPublisher;
    }
}