using MonteSeuCarro.Automovel;
using System.Collections.Generic;
using System.Linq;

namespace MonteSeuCarro.Databases
{
    interface ICarrosDAO
    {
        void Adicionar(Carro carro);
        void Atualizar(Carro carro);
        void Remover(Carro carro);
        IList<Carro> IListCarros();
    }
}
