using Aries.Aplicacao.Interfaces;
using Aries.Aplicacao.Servicos;
using Aries.Infraestrutura.Repositorio.Interfaces;
using Aries.Infraestrutura.Repositorio.Repositorios;
using Aries.Infraestrutura.Repositorio.UnitOfWork;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.IoC
{
    public class ServiceInstaller
    {
        private static Container _container = new Container();

        private ServiceInstaller() { }

        public static Container Factory()
        {
            #region Repositorios
            _container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Singleton);
            #endregion Repositorios

            #region Unit of Work
            _container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);
            #endregion Unit of Work

            #region Servicos
            _container.Register<IClienteServico, ClienteServico>(Lifestyle.Singleton);
            #endregion Servicos

            return _container;
        }
    }
}