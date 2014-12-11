﻿// Copyright 2007-2014 Chris Patterson, Dru Sellers, Travis Smith, et. al.
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
namespace MassTransit.RabbitMqTransport
{
    using System.Diagnostics.Tracing;
    using RabbitMQ.Client;


    public class RabbitMqConnectionEventSource :
        EventSource
    {
        const int ConnectionEstablishedEventId = 1;
        const int ConnectionClosedEventId = 1;

        public void ConnectionEstablished(ConnectionFactory connectionFactory)
        {
            WriteEvent(ConnectionEstablishedEventId, connectionFactory.HostName, connectionFactory.VirtualHost);
        }

        public void ConnectionClosed(ConnectionFactory connectionFactory)
        {
            WriteEvent(ConnectionClosedEventId, connectionFactory.HostName, connectionFactory.VirtualHost);
        }
    }
}