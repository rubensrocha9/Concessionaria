using MonteSeuCarro.Automovel;
using System;
using System.Collections.Generic;
using System.Linq;
using static MonteSeuCarro.Automovel.Automoveis;

namespace MonteSeuCarro.Databases
{
    public class ServerFunction
    {

        public static void SalvarDB(List<Carro> ListaDeCarros) // Salva dentro do Banco
        {
            foreach (var c in ListaDeCarros)
            {
                using (var contexto = new CarrosDAO())
                {
                    contexto.Adicionar(c);
                }
            }
        }

        public static void RecuperaCarros() // Pega as informacoes que estão armazenadas no Banco de Dados
        {
            using (var repo = new CarrosDAO())
            {
                IList<Carro> listaDeICarros = repo.IListCarros().ToList();

                Console.WriteLine("\nListagem Padrão dos Veiculos:");
                foreach (var c in listaDeICarros)
                {
                    Console.Write($"\n ID: [{c.Id}] Marca: {c.MarcaDoAutomovel} Modelo: {c.Modelo} Ano: {c.Ano} Cor: {c.CorDoCarro} Portas: {c.QntdPortas}\n");
                    foreach (var o in c.Adicionais)
                    {
                        Console.WriteLine($" Opcionais: {String.Join(", ", o.OpcionaisCarros)}");
                    }
                }
            }
        }

        public static void RecuperaCarrosAtravesDoAno()// Pega as informacoes que estão armazenadas no Banco de Dados e lista Atraves do Ano do Carro
        {
            using (var repo = new CarrosDAO())
            {
                IList<Carro> listaDeICarros = repo.IListCarros().ToList();

                Console.WriteLine("\nListagem Pelo Ano dos Carros:");
                foreach (var c in listaDeICarros.OrderByDescending(c => c.Ano))
                {
                    Console.Write($"\n ID: [{c.Id}] Marca: {c.MarcaDoAutomovel} Modelo: {c.Modelo} Ano: {c.Ano} Cor: {c.CorDoCarro} Portas: {c.QntdPortas}\n");
                    foreach (var o in c.Adicionais)
                    {
                        Console.WriteLine($" Opcionais: {String.Join(", ", o.OpcionaisCarros)}");
                    }
                }
            }
        }

        public static void RecuperaCarrosAtravesDaMarca()// Pega as informacoes que estão armazenadas no Banco de Dados e lista Atraves do Ano do Carro
        {
            using (var repo = new CarrosDAO())
            {
                IList<Carro> listaDeICarros = repo.IListCarros().ToList();
                MostrarMarca();
                Console.Write(".: ");
                var procuraMarca = Convert.ToInt32(Console.ReadLine());
                var marca = (Marca)procuraMarca;
                Console.Clear();

                Console.WriteLine("\nListagem por Marca dos Veiculos:\n");
                foreach (Carro c in listaDeICarros.Where(c => c.MarcaDoAutomovel.ToString().ToUpper() == marca.ToString().ToUpper()))
                {
                    Console.Write($"\n ID: [{c.Id}] Marca: {c.MarcaDoAutomovel} Modelo: {c.Modelo} Ano: {c.Ano} Cor: {c.CorDoCarro} Portas: {c.QntdPortas}\n");
                    foreach (var o in c.Adicionais)
                    {
                        Console.WriteLine($" Opcionais: {String.Join(", ", o.OpcionaisCarros)}");
                    }
                }
            }
        }

        public static void RemoverCarro() // remove um carro em especifico atraves do ID
        {
            using (var repo = new CarrosDAO())
            {
                Console.Write("Informe o ID do Carro: ");
                var acharID = Console.ReadLine();

                IList<Carro> listaDeICarros = repo.IListCarros().ToList();
                foreach (var c in listaDeICarros.Where(c => c.Id.ToString() == acharID.ToString()))
                {
                    repo.Remover(c);
                }
                Console.WriteLine("Veiculo Removido...");
            }
        }

        public static void ApagarBanco() // Apaga toda a informacao da Tabela do Banco de Dados
        {
            using (var repo = new CarrosDAO())
            {
                IList<Carro> listaDeICarros = repo.IListCarros().ToList();
                foreach (var c in listaDeICarros)
                {
                    repo.Remover(c);
                }

            }
        }

        public static void AtualizarCarros() // Altera um objeto dentro do Banco de Dados
        {
            using (var repo = new CarrosDAO())
            {
                Console.Write("Informe o ID do Carro: ");
                var acharID = Console.ReadLine();

                Carro carro = repo.IListCarros()
                            .Where(c => c.Id.ToString() == acharID)
                            .FirstOrDefault();

                MarcaDoVeiculo(carro);
                ConfiguracaoDosModelos(carro);
                AnoDoAutomovel(carro);
                Carro.CorDoVeiculo(carro);
                Carro.QntdDePortas(carro);
                Carro.IncluiCarroOpcinais(carro);

                repo.Atualizar(carro);
            }
        }
    }
}
