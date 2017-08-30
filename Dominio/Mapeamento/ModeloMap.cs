using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class ModeloMap : EntityTypeConfiguration<Entidades.Modelo>
    {
        public ModeloMap()
        {
            // Chave Primária
            HasKey(x => x.COD_MODELO)
                .Property(x => x.COD_MODELO)
                .HasColumnName("COD_MODELO");

            // Campos
            Property(x => x.DESCRICAO)
                .HasColumnName("DESCRICAO_MODELO")
                .HasMaxLength(45)
                .IsOptional();

            Property(x => x.INATIVO)
                .HasColumnName("INATIVO_MODELO")
                .IsRequired();

            // Tabela
            ToTable("MODELOS");

        }
    }
}
