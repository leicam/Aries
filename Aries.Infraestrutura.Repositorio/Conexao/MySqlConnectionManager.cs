using MySql.Data.MySqlClient;

namespace Aries.Infraestrutura.Repositorio.Conexao
{
    internal class MySqlConnectionManager : AbstractConnection
    {
        public MySqlConnectionManager() { }

        public static MySqlConnectionManager New()
            => new MySqlConnectionManager();

        public override object GetConnection()
            => new MySqlConnection($"Server=localhost;" +
                $"Database=aries;" +
                $"Uid=juliano;" +
                $"Pwd=039683;" +
                $"Allow User Variables=True;" +
                $"Min Pool Size=0;" +
                $"Max Pool Size=100;" +
                $"Allow Zero Datetime=true;" +
                $"Convert Zero Datetime=true");
    }
}