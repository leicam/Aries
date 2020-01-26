using Aries.Infraestrutura.Repositorio.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Contexto
{
    internal class DataInitializer : MigrateDatabaseToLatestVersion<DataContext, MigrationsConfigurstions> { }
}