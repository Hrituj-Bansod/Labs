﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    // The Observer Interface
    public interface IObserver
    {
        // Receive Notification from Subject
        void Update(string availability);
    }
    // The Subject Interface
    public interface ISubject
    {
        // Register an observer to the subject.
        void RegisterObserver(IObserver observer);

        // Remove or unregister an observer from the subject.
        void RemoveObserver(IObserver observer);

        // Notify all registered observers when the state of the subject is changed.
        void NotifyObservers();
    }

    // The ConcreteSubject class
    // The Subject have states and notifies all observers when the state changes.
    public class Subject : ISubject
    {
        // The List of Observer is going to store in the following collection object
        private List<IObserver> observers = new List<IObserver>();
        //The following properties are going to store the Product Information
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }
        // Initializing the Product information using the constructor
        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }
        //The following Method is going to return the State of the Product
        public string GetAvailability()
        {
            return Availability;
        }
        //The following Method is going to set the State of the Product
        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }
        // The observer will register with the Product using the following method
        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
            observers.Add(observer);
        }

        // The observer will unregister from the Product using the following method
        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName);
            observers.Remove(observer);
        }
        // The following Method will be sent notifications to all observers
        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                            + ProductName + ", product Price : "
                            + ProductPrice + " is Now available. So, notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                //By Calling the Update method, we are sending notifications to observers
                observer.Update(Availability);
            }
        }
    }

    // The ConcreteObserver class
    // Concrete Observer react to the updates issued by the Subject 
    public class Observer : IObserver
    {
        //The following Property is going to hold the observer's name
        public string UserName { get; set; }
        //Creating the Observer
        public Observer(string userName)
        {
            UserName = userName;
        }
        //Registering the Observer with the Subject
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        //Removing the Observer from the Subject
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
        //Observer will get a notification from the Subject using the following Method
        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}
