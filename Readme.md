# An example of sending messages to an Azure Event Hub

Here are some steps to rebuild this example:

## Getting Started

1. Go to the [Azure Portal](http://azure.com), create a new Resource Group
1. Create a new Resource Group: **name-eventhubs**

## Create Event Hub

1. Create new Event Hubs: name-hubs (takes approx. 1 min)
1. Go into name-hubs, click + Event Hub 
1. Click + Consumer Group, name it cgroup
1. Click Shared Access Policies 
1. Click + Add, name it all-policy
1. Note the **Connection string�primary key**, it will be needed later

## Create VS Project

1. Open Visual Studio (2015 Community Edition will work, it is free)
1. File -> New -> Project
1. Console Application name it **EventHubFire**
1. Right-click, Manage Nuget packages
1. Click Browse, and search �service bus�
1. Click install, and agree to the terms
1. Go to Program.cs, add `using Microsoft.ServiceBus.Messaging;`
1. Then add the following code block with `Main` function

	```C#
	var ehClient = EventHubClient.CreateFromConnectionString("connection-string");
	ehClient.SendAsync(new EventData(Encoding.UTF8.GetBytes("Hello World, This is a message.")));
	```
1. Replace **connection-string** with the connection string from the Event Hub
1. For extra clarity, add two more lines to print out a message and stall the command-line

	```C#
	Console.WriteLine("Message sent");
	Console.ReadLine();
	```
1. Click the green arrow to start
1. BOOM! You should now have sent your first message to an event hub. Go to the Azure Portal and you should be able to see that 1 message has been received (it might take a few minutes to appear on the website).
