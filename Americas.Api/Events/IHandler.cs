using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Americas.Api.Events.Contracts;

namespace Americas.Api.Events
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
