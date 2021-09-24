using System;
using System.Collections.Generic;
using CSeriesDIO.interfaces;


namespace CSeriesDIO
{
    public class SerieRepositorio : IRepositorio<serie>
    {
        private List<serie> ListaSerie = new List<serie>();
        public void Atualiza(int id, serie objeto)
        {
            ListaSerie [id] = objeto;
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}