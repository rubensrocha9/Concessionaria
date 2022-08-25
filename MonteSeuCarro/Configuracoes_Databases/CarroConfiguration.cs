using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonteSeuCarro.Automovel;
using System;
using static MonteSeuCarro.Automovel.Automoveis;

namespace MonteSeuCarro.Configuracoes_Databases
{
    public class CarroConfiguration : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {

            builder.Property(c => c.Id).HasColumnName("Id").HasColumnOrder(0); // nomeando e identificando a coluna na tabela e ordena
            builder.Property(c => c.MarcaDoAutomovel).HasColumnName("Marca").HasColumnOrder(1); // nomeando e identificando a coluna na tabela e ordena
            builder.Property(c => c.Modelo).HasColumnName("Modelo").HasColumnOrder(2); // nomeando e identificando a coluna na tabela e ordena
            builder.Property(c => c.Ano).HasColumnName("Ano").HasColumnOrder(3); // nomeando e identificando a coluna na tabela e ordena
            builder.Property(c => c.CorDoCarro).HasColumnName("Cor").HasColumnOrder(4); // nomeando e identificando a coluna na tabela e ordena
            builder.Property(c => c.QntdPortas).HasColumnName("Portas").HasColumnOrder(5); // nomeando e identificando a coluna na tabela e ordena

            builder.Property(c => c.MarcaDoAutomovel).HasConversion(                                 //
                                                            v => v.ToString(),                          // Pega o valor do Enum e converte para a String do valor informado
                                                            v => (Marca)Enum.Parse(typeof(Marca), v));  // 
        }
    }
}
