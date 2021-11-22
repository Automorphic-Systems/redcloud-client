using System;
using System.Collections.Generic;
using System.Text;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace RedcloudClient
{
    public class RedcloudWSController
    {

        public RedcloudWSController()
        {

        }

        // Create client and open connection/subscribe
        public async void Connect()
        {
            await RedcloudWSClient.ConnectAsync();
        }


        // Create call to publish message against the client 
        public async void Publish(string message)
        {
            await RedcloudWSClient.PublishAsync(message);
        }

        public async void Publish(byte[] message)
        {
            await RedcloudWSClient.PublishAsync(message);
        }

    }
}
