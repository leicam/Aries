﻿using Aries.WPF.Models.Cliente;
using Aries.WPF.Views.Cliente.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Views.Cliente
{
    public class ClienteViewModel : AbstractViewModel
    {
        #region Variaveis Privadas
        private ClienteModel _cliente = new ClienteModel();
        #endregion

        #region Propriedades
        public ClienteModel Cliente
        {
            get => _cliente;
            set => SetField(ref _cliente, value);
        }
        #endregion

        #region Comandos
        public ICadastrarClienteCommand CadastrarCliente { get; }
        #endregion

        #region Construtores
        public ClienteViewModel(ICadastrarClienteCommand cadastrarCliente)
        {
            CadastrarCliente = cadastrarCliente;
        }
        #endregion Construtores
    }
}