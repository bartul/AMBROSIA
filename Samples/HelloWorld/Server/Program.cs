﻿using Ambrosia;
using Server;
using System;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        [DataContract]
        sealed class Server : Immortal<IServerProxy>, IServer
        {
            [DataMember]
            int _messagesReceived = 0;

            public Server()
            {
            }

            public async Task<int> ReceiveMessageAsync(string message)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n!! SERVER Received message from a client: " + message);
                Console.ResetColor();

                _messagesReceived++;
                return _messagesReceived;
            }

            protected override async Task<bool> OnFirstStart()
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            int receivePort = 2001;
            int sendPort = 2000;
            string serviceName = "server";

            if (args.Length >= 1)
            {
                receivePort = int.Parse(args[0]);
            }
            if (args.Length >= 2)
            {
                sendPort = int.Parse(args[1]);
            }
            if (args.Length == 3)
            {
                serviceName = args[2];
            }

            using (var c = AmbrosiaFactory.Deploy<IServer>(serviceName, new Server(), receivePort, sendPort))
            {
                Thread.Sleep(14 * 24 * 3600 * 1000);
            }
        }
    }
}
