using Aries.Infraestrutura.Repositorio.Contexto;
using Aries.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Repositorios
{
    public abstract class AbstractRepositorio<T> : IRepositorio<T> where T : class
    {
        private AriesContext Context { get; set; }
        protected DbSet<T> Set => Context.Set<T>();

        public AbstractRepositorio(AriesContext context)
            => Context = context ?? throw new ArgumentNullException(nameof(context));

        public void AddOrUpdate(T entidade) => Set.AddOrUpdate(entidade);
        public IEnumerable<T> GetAll() => Set.AsEnumerable();
        public void Remove(T entidade) => Set.Remove(entidade);
        public void SaveChanges() => Context.SaveChanges();
    }
}