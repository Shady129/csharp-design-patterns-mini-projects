
# 📰 News Publisher – Subscriber Event Example (C#)

-------
📌 PROJECT OVERVIEW
-------

This project demonstrates how **Events and Delegates** work in C#  
using a simple **News Publisher / Subscriber system**.

The **Publisher** publishes news articles.

The **Subscribers** listen for new published news and react when the event occurs.

-------

🧠 CONCEPTS USED
-------

✔ Delegates  
✔ Events  
✔ EventHandler<T>  
✔ Publisher / Subscriber Pattern  
✔ Basic OOP Principles  

-------

🏗 PROJECT STRUCTURE
-------

NewsPublisher

│

├── Raises the NewNewsPublished event

│

▼

NewsArticle

│

├── Represents the news data  
│   (Title / Content)

│

▼

NewsSubscriber

│

├── Subscribes to the event  
├── Receives the news

│

▼

Program

│

└── Connects Publisher and Subscribers

-------

⚙ HOW IT WORKS
-------

Program creates:

1️⃣ NewsPublisher object  
2️⃣ NewsSubscriber objects  

Subscribers subscribe to the publisher.

When the publisher publishes news:

Publisher.PublishNews()

        ↓

Publisher raises event  
NewNewsPublished

        ↓

Subscribers receive notification

        ↓

Subscribers print the news to the console

-------

📊 EXECUTION FLOW
-------

Program  
   │  
   ▼  
Subscribers Subscribe  
   │  
   ▼  
Publisher.PublishNews()  
   │  
   ▼  
Event Triggered  
   │  
   ▼  
Subscribers.HandleNewNews()  
   │  
   ▼  
Console Output  

-------

💻 SAMPLE OUTPUT
-------

Subscriber1 received a new news article:

Title: Breaking News  
Content: New technology released today!

-------

📚 KEY TAKEAWAY
-------

Event = Notification system

Publisher → Raises event  
Subscribers → Listen to event  
Event Data → Sent through parameters  

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
