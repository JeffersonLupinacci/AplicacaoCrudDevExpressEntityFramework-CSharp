using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class UsuarioToolbarMap : EntityTypeConfiguration<Entidades.UsuarioToolbar>
    {
        public UsuarioToolbarMap()
        {
            // Chave Primária
            HasKey(x => x.COD)
                .Property(x => x.COD)
                .HasColumnName("COD_TOOLBAR");

            // Campos
            Property(x => x.COD_USUARIO)
                .HasColumnName("COD_USUARIO")              
                .IsRequired();

            Property(x => x.COD_EMPRESA)
                .HasColumnName("COD_EMPRESA")
                .IsRequired();

            Property(x => x.BOTAO)
                .HasColumnName("BOTAO_TOOLBAR")
                .HasMaxLength(150)
                .IsOptional();
            
            // Tabela
            ToTable("USUARIOS_TOOLBAR");
            
        }
    }
}
