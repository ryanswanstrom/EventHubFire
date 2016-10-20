# An example of sending messages to an Azure Event Hub

Here are some steps to rebuild this example:

## Getting Started

* Go to the [Azure Portal](http://azure.com), create a new Resource Group
* Create a new Resource Group: <name>-eventhubs

Create Event Hub
•	Create new Event Hubs: <name>-hubs (takes approx. 1 min)
•	Go into <name>-hubs, click + Event Hub 
•	Click + Consumer Group, name it cgroup
•	Click Shared Access Policies 
•	Click + Add, name it all-policy
Create VS Project
•	File -> New -> Project
•	Console Application named EventHubFire
•	Right-click, Manage Nuget packages
•	Click Browse, and search “service bus”
•	Click install, and agree to the terms
•	Go to program.cs
•	
