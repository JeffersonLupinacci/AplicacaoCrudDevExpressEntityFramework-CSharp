using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class EmpresaMap : EntityTypeConfiguration<Entidades.Empresa>
    {
        public EmpresaMap()
        {
            // Chave Primária
            HasKey(x => x.COD_EMPRESA)
                .Property(x => x.COD_EMPRESA)
                .HasColumnName("COD_EMPRESA");

            // Campos
            Property(x => x.RAZAOSOCIAL)
                .HasColumnName("RAZAOSOCIAL_EMPRESA")
                .HasMaxLength(90)                
                .IsOptional();

            Property(x => x.NOMEFANTASIA)
                .HasColumnName("NOMEFANTASIA_EMPRESA")
                .HasMaxLength(90)                
                .IsOptional();

            Property(x => x.INATIVO)
                .HasColumnName("INATIVO_EMPRESA")                
                .IsRequired();

            // Tabela
            ToTable("EMPRESAS") ;
            
        }
    }
}
