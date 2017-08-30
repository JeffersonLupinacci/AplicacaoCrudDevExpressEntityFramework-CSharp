using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class MarcaMap : EntityTypeConfiguration<Entidades.Marca>
    {
        public MarcaMap()
        {
            // Chave Primária
            HasKey(x => x.COD_MARCA)
                .Property(x => x.COD_MARCA)
                .HasColumnName("COD_MARCA");

            // Campos
            Property(x => x.DESCRICAO)
                .HasColumnName("DESCRICAO_MARCA")
                .HasMaxLength(45)
                .IsOptional();

            Property(x => x.INATIVO)
                .HasColumnName("INATIVO_MARCA")
                .IsRequired();

            // Tabela
            ToTable("MARCAS");

        }
    }
}
