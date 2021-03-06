﻿using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Andromeda.Bedrock.Framework.Infrastructure
{
    internal static class ServiceProviderExtensions
    {
        internal static ILoggerFactory GetLoggerFactory(this IServiceProvider serviceProvider) =>
            (ILoggerFactory)serviceProvider?.GetService(typeof(ILoggerFactory)) ?? NullLoggerFactory.Instance;
    }
}
