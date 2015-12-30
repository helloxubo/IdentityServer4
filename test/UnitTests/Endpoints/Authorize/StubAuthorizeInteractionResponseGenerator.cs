﻿using IdentityServer4.Core.ResponseHandling;
using System.Threading.Tasks;
using IdentityServer4.Core.Models;
using IdentityServer4.Core.Validation;
using System.Security.Claims;
using System;

namespace UnitTests.Endpoints.Authorize
{
    class StubAuthorizeInteractionResponseGenerator : IAuthorizeInteractionResponseGenerator
    {
        internal InteractionResponse Response { get; set; } = new InteractionResponse();

        public Task<InteractionResponse> ProcessInteractionAsync(ValidatedAuthorizeRequest request, UserConsent consent = null)
        {
            return Task.FromResult(Response);
        }
    }
}
