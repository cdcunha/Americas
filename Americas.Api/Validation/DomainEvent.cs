using Americas.Api.Events;
using Americas.Api.Events.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Americas.Api.Validation
{
    public class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            try
            {
                if (Container != null)
                {
                    var obj = Container.GetService(typeof(IHandler<T>));
                    ((IHandler<T>)obj).Handle(args);
                }
            }
            catch
            {
                //throw;
            }
        }
    }
}