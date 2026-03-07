# 📰 News Publisher – Subscriber Event Example (C#)

-------
📌 PROJECT OVERVIEW
-------

This project demonstrates how **Events and Delegates** work in C#  
using a simple **News Publisher / Subscriber system**.

A publisher sends news articles.

Multiple subscribers listen for new published news and react when the event occurs.

Subscribers can also **unsubscribe** and stop receiving notifications.

-------

🧠 CONCEPTS USED
-------

✔ Delegates  
✔ Events  
✔ EventHandler<T>  
✔ Publisher / Subscriber Pattern  
✔ Subscribe / Unsubscribe  
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
├── Can unsubscribe from the publisher

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
2️⃣ Multiple NewsSubscriber objects  

Subscribers subscribe to the publisher.

When the publisher publishes news:

Publisher.PublishNews()

        ↓

Publisher raises event  
NewNewsPublished

        ↓

All subscribers receive notification

        ↓

Subscribers print the news to the console

Later subscribers can **unsubscribe**,  
so they stop receiving future news.

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

🧪 PROGRAM SCENARIO
-------

1️⃣ Two subscribers subscribe to the publisher  

2️⃣ First news is published  
→ Both subscribers receive the news  

3️⃣ Second news is published  
→ Both subscribers receive the news  

4️⃣ Subscriber1 unsubscribes  

5️⃣ Third news is published  
→ Only Subscriber2 receives it  

6️⃣ Subscriber2 unsubscribes  

7️⃣ Final news is published  
→ No subscribers receive the news  

-------

💻 SAMPLE OUTPUT
-------

Subscriber 1 received a new news article:

Title: Breaking News  
Content: A significant event just happened!

Subscriber 2 received a new news article:

Title: Breaking News  
Content: A significant event just happened!

Subscriber 1 received a new news article:

Title: Tech Update  
Content: New gadgets are hitting the market.

Subscriber 2 received a new news article:

Title: Tech Update  
Content: New gadgets are hitting the market.

Subscriber 2 received a new news article:

Title: Weather Forecast  
Content: Expect sunny weather for the weekend.

-------

📚 KEY TAKEAWAY
-------

Event = Notification system

Publisher → Raises event  
Subscribers → Listen to event  
Event Data → Sent through parameters  

Subscribers can **subscribe or unsubscribe dynamically**.

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
