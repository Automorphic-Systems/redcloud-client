using System;
using System.Collections.Generic;
using System.Text;

namespace RedcloudClient
{
    class RedcloudMQTTController
    {

        public RedcloudMQTTController()
        {
        }


        // Create client and open connection/subscribe
        public async void Connect()
        {
            await RedcloudMQTTClient.ConnectAsyc();
        }


        // Create call to publish message against the client 
        public async void Publish(string topic, string message)
        {
            await RedcloudMQTTClient.PublishAsync(topic, message);
        }

        public async void Subscribe(string topic)
        {
            await RedcloudMQTTClient.SubscribeAsync(topic);
        }
    }
}
