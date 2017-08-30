using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Mapeamento
{
    public class UsuarioPermissaoMap : EntityTypeConfiguration<Entidades.UsuarioPermissao>
    {
        public UsuarioPermissaoMap()
        {
            // Chave Primária
            HasKey(x => x.COD)
                .Property(x => x.COD)
                .HasColumnName("COD_PERMISSAO");

            // Campos
            Property(x => x.COD_USUARIO)
                .HasColumnName("COD_USUARIO")
                .IsRequired();

            Property(x => x.COD_EMPRESA)
                .HasColumnName("COD_EMPRESA")                
                .IsRequired();

            Property(x => x.MODULO)
                .HasColumnName("MODULO_PERMISSAO")
                .IsRequired();

            Property(x => x.TAREFA)
                .HasColumnName("TAREFA_PERMISSAO")                
                .IsRequired();
            
            // Tabela
            ToTable("USUARIOS_PERMISSOES") ;
            
        }
    }
}
