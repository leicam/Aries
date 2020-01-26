using Aries.Infraestrutura.Repositorio.Conexao;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Contexto
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class DataContext : AriesContext
    {
        protected DataContext() : base((MySqlConnectionManager.New().GetConnection() as MySqlConnection))
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new DataInitializer());
        }
    }
}