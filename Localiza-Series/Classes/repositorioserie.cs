using System;
using System.Collections.Generic;

namespace Localiza.Series
{
    public class repositorioserie : IRepositorioSerie<infoserie>
    {
       private List<infoserie> lista = new List<infoserie>();
        private List<infoserie> excluidor = new List<infoserie>();
        public void Adiciona(infoserie entidade)
        {
            lista.Add(entidade);
        }

        public void Atualiza(int id, infoserie entidade)
        {
            lista[id] = entidade;
        }

        public infoserie Id_Info(int id)
        {
          return lista[id];
        }

        public List<infoserie> Lista()
        {
            return lista;
        }

        public int ProximoId()
        {
            return lista.Count;
        }
        public void Exclui(int id)
        {
           lista[id].Excluir();    
        }
    }
}