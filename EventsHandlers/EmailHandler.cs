using System;
using System.Threading;
using System.Threading.Tasks;
using MediatorPatternExample.Notifications;
using MediatR;

namespace MediatorPatternExample.EventsHandler
{
    public class EmailHandler : INotificationHandler<CustomerActionNotification>
    {
        public Task Handle(CustomerActionNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Our client {0} {1} was {2} successfully!", notification.FirstName, notification.LastName, notification.Action.ToString().ToLower());
            });
        }
    }
}