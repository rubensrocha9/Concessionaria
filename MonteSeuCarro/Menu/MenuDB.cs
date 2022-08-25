using MonteSeuCarro.Automovel;
using MonteSeuCarro.Databases;
using System;
using System.Collections.Generic;

namespace MonteSeuCarro.Menu
{
    public class MenuDB
    {
        public static void Menu_DB(List<Carro> ListaDeCarros)
        {
            int switch_op;

            Console.Clear();
            Console.WriteLine("\nMenu do Banco de Dados");
            Console.WriteLine("1 - Alterar Carro\n2 - Remover Carro\n3 - Apagar Dados do Banco\n4- Voltar");
            Console.Write(".: ");
            switch_op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (switch_op)
            {
                case 1:
                    ServerFunction.AtualizarCarros();
                    Console.Clear();
                    break;

                case 2:
                    ServerFunction.RemoverCarro();
                    Console.Clear();
                    Console.WriteLine("Veiculo Removido...");
                    break;

                case 3:
                    ServerFunction.ApagarBanco();
                    Console.Clear();
                    break;

                case 4:
                    MenuDeConfiguracao.MenuConfiguracao(ListaDeCarros);
                    break;

                default:
                    MenuDeConfiguracao.MenuConfiguracao(ListaDeCarros);
                    break;
            }
        }
    }
}
