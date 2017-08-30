using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Net.Dominio.Entidades;
using Negocio.Net.Dominio.Mapeamento;

namespace Negocio.Net.Dominio
{
    public class Contexto : DbContext
    {
        
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioGrid> UsuariosGrid { get; set; }        
        public DbSet<UsuarioToolbar> UsuariosToolbar { get; set; }
        
        public Contexto(string connStringName) :  base(connStringName)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema(Constantes.SchemaDaConexao);
            
            modelBuilder.Configurations.Add<Empresa>(new EmpresaMap());
            modelBuilder.Configurations.Add<Usuario>(new UsuarioMap());
            modelBuilder.Configurations.Add<UsuarioPermissao>(new UsuarioPermissaoMap());
            modelBuilder.Configurations.Add<UsuarioToolbar>(new UsuarioToolbarMap());
            modelBuilder.Configurations.Add<UsuarioGrid>(new UsuarioGridMap());
            
            modelBuilder.Configurations.Add<Modelo>(new ModeloMap());
            modelBuilder.Configurations.Add<Marca>(new MarcaMap());
            modelBuilder.Configurations.Add<Unidade>(new UnidadeMap());
            modelBuilder.Configurations.Add<Local>(new LocalMap());
            modelBuilder.Configurations.Add<Endereco>(new EnderecoMap());            
        }
    }

    [Obsolete("Obsoleto")]
    public class ContextoNegocioNet : Contexto {
        public ContextoNegocioNet() : base("NegocioNetContexto") { }
    }

}
