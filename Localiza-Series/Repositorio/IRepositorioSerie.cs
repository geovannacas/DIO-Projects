using System.Collections.Generic;
namespace Localiza.Series
{
    public interface IRepositorioSerie<T>
    {
        List<T> Lista();
        T Id_Info(int id);
        void Adiciona (T entidade);
        void Atualiza (int id, T entidade);
        void Exclui (int id);
        int ProximoId();
    }
}