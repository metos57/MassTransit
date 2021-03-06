// Copyright 2007-2016 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.AzureServiceBusTransport
{
    using System;


    public interface ClientSettings
    {
        /// <summary>
        /// The number of concurrent messages to process
        /// </summary>
        int MaxConcurrentCalls { get; }

        /// <summary>
        /// The number of messages to push from the server to the client
        /// </summary>
        int PrefetchCount { get; }

        /// <summary>
        /// The timeout before the session state is renewed
        /// </summary>
        TimeSpan AutoRenewTimeout { get; }

        /// <summary>
        /// The timeout before a message session is abandoned
        /// </summary>
        TimeSpan MessageWaitTimeout { get; }

        /// <summary>
        /// The lock duration for messages read from the client
        /// </summary>
        TimeSpan LockDuration { get; }

        /// <summary>
        /// The path of the message entity
        /// </summary>
        string Path { get; }

        /// <summary>
        /// Get the input address for the client on the specified host
        /// </summary>
        Uri GetInputAddress(Uri serviceUri);
    }
}