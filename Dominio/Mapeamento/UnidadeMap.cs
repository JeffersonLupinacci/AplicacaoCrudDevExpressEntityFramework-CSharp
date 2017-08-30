using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class UnidadeMap : EntityTypeConfiguration<Entidades.Unidade>
    {
        public UnidadeMap()
        {
            // Chave Primária
            HasKey(x => x.COD_UNIDADE)
                .Property(x => x.COD_UNIDADE)
                .HasColumnName("COD_UNIDADE");

            // Campos
            Property(x => x.DESCRICAO)
                .HasColumnName("DESCRICAO_UNIDADE")
                .HasMaxLength(45)
                .IsRequired();

            Property(x => x.INATIVO)
                .HasColumnName("INATIVO_UNIDADE")
                .IsRequired();

            Property(x => x.SIGLA)
                .HasColumnName("SIGLA_UNIDADE")
                .HasMaxLength(3)
                .IsRequired();

            Property(x => x.FATOR)
                .HasColumnName("FATOR_UNIDADE")
                .IsRequired();

            Property(x => x.COD_UNIDADE_MAIOR)
            .HasColumnName("COD_UNIDADE_MAIOR")
            .IsOptional();

            // Tabela
            ToTable("UNIDADES");

        }
    }
}
