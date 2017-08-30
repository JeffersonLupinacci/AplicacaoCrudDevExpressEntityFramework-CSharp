using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class LocalMap : EntityTypeConfiguration<Entidades.Local>
    {
        public LocalMap()
        {
            // Chave Primária
            HasKey(x => x.COD_LOCAL)
                .Property(x => x.COD_LOCAL)
                .HasColumnName("COD_LOCAL");

            // Campos
            Property(x => x.DESCRICAO)
                .HasColumnName("DESCRICAO_LOCAL")
                .HasMaxLength(120)
                .IsOptional();
            
            // Tabela
            ToTable("LOCAIS");

        }
    }
}
