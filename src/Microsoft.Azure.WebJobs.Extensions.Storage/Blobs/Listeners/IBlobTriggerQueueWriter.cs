﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Host.Blobs.Listeners
{
    internal interface IBlobTriggerQueueWriter
    {
        /// <summary>
        /// Enqueue the message into the queue.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The name of the queue and the Id of the enqueued message.</returns>
        Task<(string QueueName, string MessageId)> EnqueueAsync(BlobTriggerMessage message, CancellationToken cancellationToken);
    }
}
