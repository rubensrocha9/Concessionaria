using MonteSeuCarro.Automovel;
using MonteSeuCarro.Menu;
using System;
using System.Collections.Generic;

namespace MonteSeuCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> ListaDeCarros = new List<Carro>();

            MenuDeConfiguracao.MenuConfiguracao(ListaDeCarros);
        }
    }
}
