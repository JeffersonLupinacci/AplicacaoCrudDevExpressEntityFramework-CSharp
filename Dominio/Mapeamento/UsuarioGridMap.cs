using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class UsuarioGridMap : EntityTypeConfiguration<Entidades.UsuarioGrid>
    {
        public UsuarioGridMap()
        {
            // Chave Primária
            HasKey(x => x.COD)
                .Property(x => x.COD)
                .HasColumnName("COD_GRID");

            // Campos
            Property(x => x.COD_USUARIO)
                .HasColumnName("COD_USUARIO")              
                .IsRequired();

            Property(x => x.COD_EMPRESA)
                .HasColumnName("COD_EMPRESA")
                .IsRequired();

            Property(x => x.XML)
                .HasColumnName("XML_GRID")
                .HasMaxLength(5000)
                .IsOptional();

            Property(x => x.FORMULARIO)
                .HasColumnName("FORMULARIO_GRID")
                .HasMaxLength(150)
                .IsOptional();

            // Tabela
            ToTable("USUARIOS_GRID");
            
        }
    }
}
