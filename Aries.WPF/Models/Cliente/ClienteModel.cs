using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Models.Cliente
{
    public class ClienteModel : AbstractModel
    {
        #region Variaveis Privadas
        private string _nome = string.Empty;
        private string _sobrenome = string.Empty;
        private string _documento = string.Empty;
        private string _email = string.Empty;
        #endregion

        #region Propriedades
        public string Nome
        {
            get => _nome;
            set => SetField(ref _nome, value);
        }

        public string Sobrenome
        {
            get => _sobrenome;
            set => SetField(ref _sobrenome, value);
        }

        public string Documento
        {
            get => _documento;
            set => SetField(ref _documento, value);
        }

        public string Email
        {
            get => _email;
            set => SetField(ref _email, value);
        }
        #endregion
    }
}