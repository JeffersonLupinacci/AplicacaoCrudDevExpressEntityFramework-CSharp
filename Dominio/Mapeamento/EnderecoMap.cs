using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class EnderecoMap : EntityTypeConfiguration<Entidades.Endereco>
    {
        public EnderecoMap()
        {
            // Chave Primária
            HasKey(x => x.COD_ENDERECO)
                .Property(x => x.COD_ENDERECO)
                .HasColumnName("COD_ENDERECO");

            // Campos
            Property(x => x.DESCRICAO)
                .HasColumnName("DESCRICAO_ENDERECO")
                .HasMaxLength(120)
                .IsOptional();
            
            // Tabela
            ToTable("ENDERECOS");

        }
    }
}
