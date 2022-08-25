using System;

namespace MonteSeuCarro.Automovel
{
    public class Automoveis
    {
        public enum Marca
        {
            Volkswagen,
            Chevrolet,
            Fiat,
            Peugeot,
            Ford
        }

        public Marca MarcaDoAutomovel { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Automoveis()
        {

        }

        // imprime na tela o 
        public static void MostrarMarca()
        {
            Console.WriteLine("Qual Marca Deseja escolher:");
            foreach (var marca in Enum.GetValues(typeof(Marca)))
            {
                Console.WriteLine($"\t{Convert.ToInt32(marca)} - {marca}");
            }
        }

        //Pega a marca do Veiculo
        public static void MarcaDoVeiculo(Carro carro)
        {
            int auxilixarMarca;

            MostrarMarca();
            Console.Write(".: ");
            auxilixarMarca = Convert.ToInt32(Console.ReadLine());
            carro.MarcaDoAutomovel = (Marca)auxilixarMarca;
            Console.WriteLine("Marca Escolhida: " + carro.MarcaDoAutomovel);

        }

        //Pega do usuario o Modelo
        public static void ConfiguracaoDosModelos(Carro carro)
        {
            Console.Write("Informe o Modelo que deseja: ");
            carro.Modelo = Console.ReadLine();

        }

        //pega o ano do veiculo
        public static void AnoDoAutomovel(Carro carro)
        {
            Console.Write("Informe o Ano do Carro: ");
            carro.Ano = Convert.ToInt32(Console.ReadLine());

        }
    }
}
