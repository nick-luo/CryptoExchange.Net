﻿using System;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Objects;

namespace CryptoExchange.Net.Interfaces
{
    /// <summary>
    /// Base class for rest API implementations
    /// </summary>
    public interface IRestClient: IDisposable
    {
        /// <summary>
        /// The options provided for this client
        /// </summary>
        ClientOptions ClientOptions { get; }

        /// <summary>
        /// The total amount of requests made with this client
        /// </summary>
        int TotalRequestsMade { get; }
    }
}