# 📈 Stock Price Event Example (C#)

-------
📌 PROJECT OVERVIEW
-------

This project demonstrates how **Events and Delegates** work in C#  
using a simple **Stock Price Notification System**.

A stock publishes a price change event.

Investors subscribe to the stock and receive notifications  
whenever the price changes.

-------

🧠 CONCEPTS USED
-------

✔ Delegates  
✔ Events  
✔ EventHandler<T>  
✔ EventArgs  
✔ Publisher / Subscriber Pattern  

-------

🏗 PROJECT STRUCTURE
-------

Stock

│

├── Raises PriceChanged event

│

▼

StockPriceEventArgs

│

├── Carries event data  
│   (OldPrice / NewPrice)

│

▼

StockSubscriber

│

├── Subscribes to stock price changes

│

▼

Program

│

└── Connects everything together

-------

⚙ HOW IT WORKS
-------

Program creates:

1️⃣ Stock object  
2️⃣ Multiple investors (subscribers)

Investors subscribe to stock price updates.

When the stock price changes:

Stock.ChangePrice()

        ↓

Stock raises event  
PriceChanged

        ↓

Subscribers receive notification

        ↓

Subscribers print the price change

-------

📊 EXECUTION FLOW
-------

Program  
   │  
   ▼  
Subscribers Subscribe  
   │  
   ▼  
Stock.ChangePrice()  
   │  
   ▼  
PriceChanged Event  
   │  
   ▼  
Subscribers.HandlePriceChanged()  
   │  
   ▼  
Console Output  

-------

💻 SAMPLE OUTPUT
-------

Investor 1 noticed price change: 150 → 155  
Investor 2 noticed price change: 150 → 155  

Investor 1 noticed price change: 155 → 160  
Investor 2 noticed price change: 155 → 160  

-------

📚 KEY TAKEAWAY
-------

Event = Notification system

Publisher → Raises event  
Subscribers → Listen to event  
EventArgs → Carries event data  

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
