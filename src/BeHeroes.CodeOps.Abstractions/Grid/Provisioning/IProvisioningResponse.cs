﻿using System.Net;

namespace BeHeroes.CodeOps.Abstractions.Grid.Provisioning
{
    public interface IProvisioningResponse
    {
        HttpStatusCode Status { get; }

        HttpContent? Content { get; }
    }
}
