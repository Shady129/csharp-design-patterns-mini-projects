# ⚡ Thermostat Event Example (C#)

-------
📌 PROJECT OVERVIEW
-------

This project demonstrates how Events and Delegates work in C# 
using a simple Thermostat temperature monitoring system.

The Thermostat acts as a Publisher that raises an event when 
the temperature changes.

The Display acts as a Subscriber that listens to the event and 
prints the temperature change to the console.

-------

🧠 CONCEPTS USED
-------

✔ Delegates  
✔ Events  
✔ EventHandler<T>  
✔ EventArgs  
✔ Publisher / Subscriber Pattern  
✔ Basic OOP Principles  

-------

🏗 PROJECT STRUCTURE
-------

Thermostat

│

├── Raises the TemperatureChanged event

│

▼

TemperatureChangedEventArgs

│

├── Carries event data  
│   (OldTemperature / NewTemperature)

│

▼

Display

│

├── Subscribes to the event

│

▼

Program

│

└── Connects everything together

-------

⚙ HOW IT WORKS
-------

Program creates:

1️⃣ Thermostat object  
2️⃣ Display object  

Display subscribes to the Thermostat event.

When temperature changes:

Thermostat.SetTemperature()

        ↓

Thermostat raises event  
TemperatureChanged

        ↓

Display receives event

        ↓

Display prints temperature change  
to the console

-------

📊 EXECUTION FLOW
-------

Program  
   │  
   ▼  
Display.Subscribe(thermostat)  
   │  
   ▼  
Thermostat.SetTemperature()  
   │  
   ▼  
TemperatureChanged Event  
   │  
   ▼  
Display.HandleTemperatureChange()  
   │  
   ▼  
Console Output  

-------

💻 SAMPLE OUTPUT
-------

Temperature changed

Old Temperature : 25  
New Temperature : 30  
Difference      : 5  

-------

📚 KEY TAKEAWAY
-------

Event = Notification system

Publisher → Raises event  
Subscriber → Listens to event  
EventArgs → Carries data  

-------

🛠 TECHNOLOGIES
-------

Language : C#  
Framework : .NET  
Type : Console Application  
Concept : Events & Delegates  

-------

👨‍💻 AUTHOR
-------

Shady Mahmoud
