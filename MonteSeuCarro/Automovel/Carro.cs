using System;
using System.Collections.Generic;

namespace MonteSeuCarro.Automovel
{

    public class Carro : Automoveis
    {
        public int Id { get; set; }
        public int QntdPortas { get; set; }
        public string CorDoCarro { get; set; }
        public ICollection<AdicionaisCarro> Adicionais { get; set; } // relacionamenro 1 para N

        public Carro()
        {
            Adicionais = new List<AdicionaisCarro>();
        }

        //Pega do usuario a quantidade de portas no veiculo
        public static void QntdDePortas(Carro carro)
        {
            Console.Write("Informe a Quantidade de Portas do Carro: ");
            carro.QntdPortas = Convert.ToInt32(Console.ReadLine());
        }

        public static void CorDoVeiculo(Carro carro)
        {
            Console.Write("Informe a Cor do Carro: ");
            carro.CorDoCarro = Console.ReadLine();
        }

        //pede a quantidade de Opcionais e pede para o usuario informar quais sao esses Opcionais
        public static void IncluiCarroOpcinais(Carro carro)
        {
            int numeroDeOpcionais;

            Console.Write("Quantos Opcionais deseja adicionar: ");
            numeroDeOpcionais = Convert.ToInt32(Console.ReadLine());

            carro.Adicionais.Clear();

            if (numeroDeOpcionais == 0)
            {
                carro.Adicionais.Add(new AdicionaisCarro() { OpcionaisCarros = "Nenhum Opcional Adicionado" });
            }
            for (int i = 0; i < numeroDeOpcionais; i++)
            {
                Console.Write(".: ");
                carro.Adicionais.Add(new AdicionaisCarro() { OpcionaisCarros = Console.ReadLine() });
            }

        }
    }
}
