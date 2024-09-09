namespace Infra.Repositorio.Generics
{
    public class InterfaceGenerics<T> where T : class
    {
        public interface InterfaceGeneric<T> where T : class
        {
            Task Add(T Objeto);
            Task Update(T Objeto);
            Task Delete(T Objeto);
            Task<T> GetEntityById(int Id);
            Task<List<T>> List();

        }
    }
}