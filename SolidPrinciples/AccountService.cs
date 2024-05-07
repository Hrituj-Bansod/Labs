using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    // Main Service class calling other classes for functionality 
    public class AccountService 
    {
        private readonly AccountRepository _repository;
        private readonly AccountNotification _notification;

        public AccountService(AccountRepository repository, AccountNotification notification)
        {
            _repository = repository;
            _notification = notification;
        }

        public void OpenAccount(string accountDetails)
        {
            // Process account opening details
            Console.WriteLine($"Opening account with details: {accountDetails}");

            // Store account details
            _repository.Store(accountDetails);

            // Send notification
            _notification.SendMessage();
        }
    }

    // Account repository class
    public class AccountRepository 
    {
        public void Store(string accountDetails)
        {
            // Store account details in the database
            Console.WriteLine($"Storing account details: {accountDetails}");
        }
    }

    // Account notification class
    public class AccountNotification 
    {
        public void SendMessage()
        {
            // Send welcome message
            Console.WriteLine("Sending welcome message");
        }
    }
}
