namespace Dominio.Repositorio
{
    public interface IRepositorioCRUD <T> where T : class
    {
        string Create(T entity);
        string Update(T entity);
        bool Delete(T entity);
        T Find(string id);

    }
}
