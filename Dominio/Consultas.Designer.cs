﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Negocio.Net.Dominio {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Consultas {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Consultas() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dominio.Consultas", typeof(Consultas).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select
        ///  &quot;COD_EMPRESA&quot; as COD, 
        ///  &quot;RAZAOSOCIAL_EMPRESA&quot; as NOME
        ///from
        ///  &quot;EMPRESAS&quot;
        ///where
        ///  &quot;INATIVO_EMPRESA&quot; = false.
        /// </summary>
        internal static string sqlEmpresasAtivas {
            get {
                return ResourceManager.GetString("sqlEmpresasAtivas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select
        ///  &quot;USUARIOS_DA_EMPRESA&quot;.&quot;COD_EMPRESA&quot;
        ///from
        ///  public.&quot;USUARIOS_DA_EMPRESA&quot;
        ///  inner join public.&quot;EMPRESAS&quot; on (&quot;USUARIOS_DA_EMPRESA&quot;.&quot;COD_EMPRESA&quot; = &quot;EMPRESAS&quot;.&quot;COD_EMPRESA&quot;) and (&quot;EMPRESAS&quot;.&quot;INATIVO_EMPRESA&quot; = FALSE)
        ///where
        ///  &quot;USUARIOS_DA_EMPRESA&quot;.&quot;COD_USUARIO&quot; = @COD_USUARIO and
        ///  &quot;USUARIOS_DA_EMPRESA&quot;.&quot;COD_EMPRESA&quot; = @COD_EMPRESA
        ///order by
        ///  1.
        /// </summary>
        internal static string sqlEmpresasDoUsuario {
            get {
                return ResourceManager.GetString("sqlEmpresasDoUsuario", resourceCulture);
            }
        }
    }
}