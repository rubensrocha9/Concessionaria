namespace MonteSeuCarro.Automovel
{
    public class AdicionaisCarro
    {

        public int Id { get; set; }
        public int CarroId { get; set; }
        public string OpcionaisCarros { get; set; }
        public Carro Carro { get; set; }

        public AdicionaisCarro()
        {
        }
    }
}
