﻿using Fingo.Auth.Domain.Infrastructure.EventBus.Events.Base;

namespace Fingo.Auth.Domain.Infrastructure.EventBus.Events.Policy
{
    public class PolicyRemoved : EventBase
    {
        public PolicyRemoved(int projectId , DbAccess.Models.Policies.Enums.Policy policy)
        {
            Policy = policy;
            ProjectId = projectId;
        }

        public DbAccess.Models.Policies.Enums.Policy Policy { get; }
        public int ProjectId { get; }

        public override string ToString()
        {
            return $"Policy ({Policy}) removed from project (id: {ProjectId}).";
        }
    }
}