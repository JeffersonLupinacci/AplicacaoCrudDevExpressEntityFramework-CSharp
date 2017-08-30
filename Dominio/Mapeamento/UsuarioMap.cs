using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class UsuarioMap : EntityTypeConfiguration<Entidades.Usuario>
    {
        public UsuarioMap()
        {
            // Chave Primária
            HasKey(x => x.COD)
                .Property(x => x.COD)
                .HasColumnName("COD_USUARIO");

            // Campos
            Property(x => x.NOME)
                .HasColumnName("NOME_USUARIO")
                .HasMaxLength(45)                
                .IsOptional();

            Property(x => x.LOGIN)
                .HasColumnName("LOGIN_USUARIO")
                .HasMaxLength(45)
                .IsOptional();

            Property(x => x.SENHA)
                .HasColumnName("SENHA_USUARIO")
                .HasMaxLength(90)
                .IsOptional();

            Property(x => x.INATIVO)
                .HasColumnName("INATIVO_USUARIO")                
                .IsRequired();

            Property(x => x.ADMINISTRADOR)
                .HasColumnName("ADMINISTRADOR_USUARIO")
                .IsRequired();

            // Tabela
            ToTable("USUARIOS") ;
            
        }
    }
}
