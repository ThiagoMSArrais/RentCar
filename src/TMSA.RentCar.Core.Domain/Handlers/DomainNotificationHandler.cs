using System;
using System.Collections.Generic;
using System.Text;
using TMSA.RentCar.Core.Domain.Events;
using TMSA.RentCar.Core.Domain.Interfaces;

namespace TMSA.RentCar.Core.Domain.Handlers
{
    public class DomainNotificationHandler : IHandler<DomainNotification>
    {
        private List<DomainNotification> _notifications;

        public DomainNotificationHandler(List<DomainNotification> notifications)
        {
            _notifications = notifications;
        }

        public void Handle(DomainNotification args)
        {
            _notifications.Add(args);
        }

        public IEnumerable<DomainNotification> Notify()
        {
            return GetValues();
        }

        public List<DomainNotification> GetValues()
        {
            return _notifications;
        }

        public bool HasNotification()
        {
            return GetValues().Count > 0;
        }

        public void Dispose()
        {
            this._notifications = new List<DomainNotification>();
        }
    }
}
