using System;
using System.Text;

namespace EventHubFire
{
    using Microsoft.ServiceBus.Messaging;

    class Program
    {
        static void Main(string[] args)
        {
            //use the connection string from a newly created shared access policy on the event hub
            var ehClient = EventHubClient.CreateFromConnectionString("<connection-string>");
            ehClient.SendAsync(new EventData(Encoding.UTF8.GetBytes("Hello World, This is a message.")));

            Console.WriteLine("Message sent");
            Console.ReadLine();
        }
    }
}
