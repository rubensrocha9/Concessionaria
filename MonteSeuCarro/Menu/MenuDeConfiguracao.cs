using MonteSeuCarro.Automovel;
using MonteSeuCarro.Databases;
using System;
using System.Collections.Generic;

namespace MonteSeuCarro.Menu
{
    public class MenuDeConfiguracao : Carro
    {

        public static void MenuConfiguracao(List<Carro> ListaDeCarros)
        {
            int repeticaoMenu;
            int op;

            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1 - Adicionar Veiculo\n2 - Listar Veiculos\n3 - Banco de Dados\n4 - Sair");
                Console.Write(".: ");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (op)
                {
                    case 1:
                        int quantidadeCarro;
                        Console.Write("Quantos Carros deseja Configurar: ");
                        quantidadeCarro = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < quantidadeCarro; i++)
                        {
                            Carro carro = new Carro();
                            Console.Clear();
                            MarcaDoVeiculo(carro);
                            ConfiguracaoDosModelos(carro);
                            AnoDoAutomovel(carro);
                            CorDoVeiculo(carro);
                            QntdDePortas(carro);
                            IncluiCarroOpcinais(carro);

                            ListaDeCarros.Add(carro);
                        }
                        ServerFunction.SalvarDB(ListaDeCarros);

                        repeticaoMenu = 1;
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        ListagemDosVeiculos(ListaDeCarros);
                        repeticaoMenu = 1;
                        break;

                    case 3:
                        Console.Clear();
                        MenuDB.Menu_DB(ListaDeCarros);
                        repeticaoMenu = 1;
                        break;

                    case 4:
                        repeticaoMenu = -1;
                        break;

                    default:
                        repeticaoMenu = -1;
                        break;
                }
            } while (repeticaoMenu == 1);
        }

        public static void ListagemDosVeiculos(List<Carro> ListaDeCarros)
        {
            int op;

            Console.Clear();
            Console.WriteLine("\nMenu de Listagem");
            Console.WriteLine("1 - Lista Padrão\n2 - Listar pelo Ano\n3 - Lista Filtrada (Marca)\n4 - Voltar");
            Console.Write(".: ");
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (op)
            {
                case 1:
                    ServerFunction.RecuperaCarros();
                    break;

                case 2:
                    ServerFunction.RecuperaCarrosAtravesDoAno();
                    break;

                case 3:
                    ServerFunction.RecuperaCarrosAtravesDaMarca();
                    break;

                case 4:
                    MenuConfiguracao(ListaDeCarros);
                    break;

                default:
                    MenuConfiguracao(ListaDeCarros);
                    break;
            }
        }
    }
}
