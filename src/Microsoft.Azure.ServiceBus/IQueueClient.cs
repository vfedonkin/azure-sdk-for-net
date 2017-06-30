﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.ServiceBus
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Core;
    using Primitives;

    /// <summary>
    /// QueueClient can be used for all basic interactions with a Service Bus Queue.
    /// </summary>
    /// <example>
    /// Create a new QueueClient
    /// <code>
    /// IQueueClient queueClient = new QueueClient(
    ///     namespaceConnectionString,
    ///     queueName,
    ///     ReceiveMode.PeekLock,
    ///     RetryExponential);
    /// </code>
    /// 
    /// Send a message to the queue:
    /// <code>
    /// byte[] data = GetData();
    /// await queueClient.SendAsync(data);
    /// </code>
    /// 
    /// Register a message handler which will be invoked every time a message is received.
    /// <code>
    /// queueClient.RegisterMessageHandler(
    ///        async (message, token) =&gt;
    ///        {
    ///            // Process the message
    ///            Console.WriteLine($"Received message: SequenceNumber:{message.SystemProperties.SequenceNumber} Body:{Encoding.UTF8.GetString(message.Body)}");
    ///
    ///            // Complete the message so that it is not received again.
    ///            // This can be done only if the queueClient is opened in ReceiveMode.PeekLock mode.
    ///            await queueClient.CompleteAsync(message.SystemProperties.LockToken);
    ///        });
    /// </code>
    /// </example>
    /// <remarks>Use <see cref="IMessageSender"/> or <see cref="IMessageReceiver"/> for advanced set of functionality.</remarks>
    /// <seealso cref="QueueClient"/>
    public interface IQueueClient : IReceiverClient, ISenderClient
    {
        /// <summary>
        /// Gets the name of the queue.
        /// </summary>
        string QueueName { get; }

        /// <summary>
        /// Receive session messages continously from the queue. Registers a message handler and begins a new thread to receive session-messages.
        /// This handler(<see cref="Func{IMessageSession, Message, CancellationToken, Task}"/>) is awaited on every time a new message is received by the queue client.
        /// </summary>
        /// <param name="handler">A <see cref="Func{IMessageSession, Message, CancellationToken, Task}"/> that processes messages. 
        /// <see cref="IMessageSession"/> contains the session information, and must be used to perform Complete/Abandon/Deadletter or other such operations on the <see cref="Message"/></param>
        /// <param name="exceptionReceivedHandler">A <see cref="Func{T1, TResult}"/> that is invoked during exceptions.
        /// <see cref="ExceptionReceivedEventArgs"/> contains contextual information regarding the exception.</param>
        /// <remarks>  Enable prefetch to speeden up the receive rate. 
        /// Use <see cref="RegisterSessionHandler(Func{IMessageSession,Message,CancellationToken,Task}, SessionHandlerOptions)"/> to configure the settings of the pump.</remarks>
        void RegisterSessionHandler(Func<IMessageSession, Message, CancellationToken, Task> handler, Func<ExceptionReceivedEventArgs, Task> exceptionReceivedHandler);

        /// <summary>
        /// Receive session messages continously from the queue. Registers a message handler and begins a new thread to receive session-messages.
        /// This handler(<see cref="Func{IMessageSession, Message, CancellationToken, Task}"/>) is awaited on every time a new message is received by the queue client.
        /// </summary>
        /// <param name="handler">A <see cref="Func{IMessageSession, Message, CancellationToken, Task}"/> that processes messages. 
        /// <see cref="IMessageSession"/> contains the session information, and must be used to perform Complete/Abandon/Deadletter or other such operations on the <see cref="Message"/></param>
        /// <param name="sessionHandlerOptions">Options used to configure the settings of the session pump.</param>
        /// <remarks>  Enable prefetch to speeden up the receive rate. </remarks>
        void RegisterSessionHandler(Func<IMessageSession, Message, CancellationToken, Task> handler, SessionHandlerOptions sessionHandlerOptions);
    }
}