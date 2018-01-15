using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Americas.Api.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}