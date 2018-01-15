using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Americas.Api.Events
{
    public interface IContainer
    {
        T GetService<T>();
        object GetService(Type serviceType);
        IEnumerable<T> GetServices<T>();
        IEnumerable<object> GetServices(Type serviceType);
    }
}
