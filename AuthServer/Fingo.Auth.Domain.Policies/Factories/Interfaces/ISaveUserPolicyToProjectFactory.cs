﻿using Fingo.Auth.Domain.Infrastructure.Interfaces;
using Fingo.Auth.Domain.Policies.Factories.Actions.Interfaces;

namespace Fingo.Auth.Domain.Policies.Factories.Interfaces
{
    public interface ISaveUserPolicyToProjectFactory : IActionFactory
    {
        ISaveUserPolicyToProject Create();
    }
}