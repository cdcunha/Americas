using Americas.Api.Models;
using Americas.Api.Repository.Contracts;
using Americas.Api.Validation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Americas.Api.Repositories
{
    public class FapaccadRepository : IFapaccadRepository
    {
        private AmericasDbContext _context;

        public FapaccadRepository(AmericasDbContext context)
        {
            _context = context;
        }

        private bool HasDBConnectionAndNotificate()
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertTrue(this._context.Database.Exists(), "Sem conexão com o Banco de Dados")
            );
        }

        public void Add(Fapaccad fapaccad)
        {
            this._context.Fapaccads.Add(fapaccad);
        }

        public Fapaccad Find(string cod_pac)
        {
            return this._context.Fapaccads.Find(cod_pac);
        }

        public IEnumerable<Fapaccad> GetAll(int offset = 0, int length = 50)
        {
            return this._context.Fapaccads.Skip(50).Take(length).ToList();
        }

        public void Remove(Fapaccad fapaccad)
        {
            this._context.Fapaccads.Remove(fapaccad);
        }
        
        public void Update(Fapaccad fapaccad)
        {
            this._context.Entry<Fapaccad>(fapaccad).State = EntityState.Modified;
        }
    }
}