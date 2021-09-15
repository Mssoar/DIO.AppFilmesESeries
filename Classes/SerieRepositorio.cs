using System;
using System.Collections.Generic;
using FilmesESeries;
using FilmesESeries.Classes;
using FilmesESeries.Interfaces;

namespace FilmesESeries {
    public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}

        internal void Atualiza(int indiceFilmes, Filme atualizaFilmes)
        {
            throw new NotImplementedException();
        }

        internal void Insere(Filme novoFilme)
        {
            throw new NotImplementedException();
        }
    }
}