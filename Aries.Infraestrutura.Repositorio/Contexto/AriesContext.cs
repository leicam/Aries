using Aries.Dominio.Entidades.Cliente;
using Aries.Infraestrutura.Repositorio.Mapeamento;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Contexto
{
    public class AriesContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected AriesContext(DbConnection connection) : base(connection, true) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new DocumentoMap());
            modelBuilder.Configurations.Add(new EmailMap());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            try
            {
                var saveChanges = base.SaveChanges();
                return saveChanges;
            }
            catch (DbEntityValidationException ex)
            {
                RollbackChanges();
                throw new Exception(EntityValidationErrorsReturn(ex.EntityValidationErrors));
            }
            catch (Exception ex)
            {
                RollbackChanges();
                throw ex;
            }
        }

        private string EntityValidationErrorsReturn(IEnumerable<DbEntityValidationResult> entityValidationErrors)
        {
            var messageError = string.Empty;
            foreach (var eve in entityValidationErrors)
            {
                messageError += $"Entidade do tipo '{ eve.Entry.Entity.GetType().Name }' no estado '{ eve.Entry.State }' possui os seguintes erros de validação: ";
                foreach (var ve in eve.ValidationErrors)
                    messageError += $"- Property: {ve.PropertyName.ToUpper()}, Erro: {ve.ErrorMessage}\n";
            }
            return messageError;
        }

        public void RollbackChanges()
        {
            if (!ChangeTracker.HasChanges())
                return;

            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default:
                        break;
                }
            }

            SaveChanges();
        }
    }
}