﻿using Aries.WPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Views.Cliente.Commands
{
    public class CadastrarClienteCommand : AbstractCommand
    {
        public override void Execute(object parameter)
            => GerenciadorTelas.CadastrarCliente();
    }
}