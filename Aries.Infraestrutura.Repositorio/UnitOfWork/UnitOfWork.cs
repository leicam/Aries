using Aries.Infraestrutura.Repositorio.Interfaces;

namespace Aries.Infraestrutura.Repositorio.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Propriedades
        public IClienteRepositorio ClienteRepositorio { get; }
        public IProdutoRepositorio ProdutoRepositorio { get; }
        #endregion Propriedades

        #region Construtores
        public UnitOfWork(IClienteRepositorio clienteRepositorio,
                          IProdutoRepositorio produtoRepositorio)
        {
            ClienteRepositorio = clienteRepositorio;
            ProdutoRepositorio = produtoRepositorio;
        }
        #endregion
    }
}