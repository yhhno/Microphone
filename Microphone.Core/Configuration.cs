﻿using System;

namespace Microphone.Core
{
    public static class Configuration
    {
        public static Uri GetUri(int port = 0)
        {
            port = port == 0 ? FreeTcpPort() : port;
            var uri = new Uri("http://localhost:" + port);
            return uri;
        }

        private static int FreeTcpPort()
        {
            return 8181;
            //var l = new TcpListener(IPAddress.Loopback, 0);
            //l.Start();
            //var port = ((IPEndPoint)l.LocalEndpoint).Port;
            //l.Stop();
            //return port;
        }
    }
}