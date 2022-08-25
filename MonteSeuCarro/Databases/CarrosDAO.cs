using Microsoft.EntityFrameworkCore;
using MonteSeuCarro.Automovel;
using MonteSeuCarro.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonteSeuCarro.Databases
{
    internal class CarrosDAO : IDisposable, ICarrosDAO
    {
        private ConcessionariaContext contexto;

        public CarrosDAO()
        {
            this.contexto = new ConcessionariaContext();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void Adicionar(Carro carro)
        {
            contexto.Carros.Add(carro);
            contexto.SaveChanges();
        }

        public void Atualizar(Carro carro)
        {
            contexto.Carros.Update(carro);
            contexto.SaveChanges();
        }

        public void Remover(Carro carro)
        {
            contexto.Carros.Remove(carro);
            contexto.SaveChanges();
        }

        public IQueryable<Carro> IListCarros()
        {
            return contexto.Carros.Include(p => p.Adicionais);
        }
    }
}
