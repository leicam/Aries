﻿using Aries.Aplicacao.Interfaces;
using Aries.Aplicacao.Servicos;
using Aries.Dominio.Entidades.Cliente;
using Aries.Infraestrutura.Repositorio.Contexto;
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
    internal static class ServiceInstaller
    {
        internal static Container Factory(Container container)
        {

            container.Register<IClienteServico, ClienteServico>(Lifestyle.Singleton);

            return container;
        }
    }
}