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
    public class DataContext : AriesContext
    {
        public DataContext() : base((MySqlConnectionManager.New().GetConnection() as MySqlConnection))
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
            Database.SetInitializer(new DataInitializer());
        }
    }
}