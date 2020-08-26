using Nelibur.ObjectMapper;

namespace Aries.Infraestrutura.Utilidades.Converter
{
    public static class Mapper
    {
        public static TTarget Map<TSource, TTarget>(TSource source)
        {
            TinyMapper.Bind<TSource, TTarget>();
            return TinyMapper.Map<TSource, TTarget>(source);
        }
    }
}
