using Americas.Api.Events.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Americas.Api.Events
{
    public class DomainNotification : IDomainEvent
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DateOccurred { get; private set; }

        public DomainNotification(string key, string value)
        {
            Key = key;
            Value = value;
            DateOccurred = DateTime.Now;
        }
    }
}