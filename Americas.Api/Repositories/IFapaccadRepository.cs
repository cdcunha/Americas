using Americas.Api.Models;
using System.Collections.Generic;

namespace Americas.Api.Repository.Contracts
{
    public interface IFapaccadRepository
    {
        void Add(Fapaccad fapaccad);
        IEnumerable<Fapaccad> GetAll(int offset = 0, int length = 50);
        Fapaccad Find(string cod_pac);
        void Remove(Fapaccad fapaccad);
        void Update(Fapaccad fapaccad);
    }
}
