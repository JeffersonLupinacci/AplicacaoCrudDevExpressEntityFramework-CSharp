using System;

[AttributeUsage(AttributeTargets.All)]
public class PersonalizarColuna : System.Attribute
{    
    /// <summary>
    /// Descrição da Coluna para o usuário
    /// </summary>
    public String Caption { get; set; }
    
    /// <summary>
    /// Coluna de Visualização do Objeto Linkado por Foreing Key
    /// </summary>
    public String Coluna { get; set; }

    /// <summary>
    /// Determinante se a Coluna Ficará Visivel 
    /// </summary>
    public bool Visivel { get; set; }

    public bool ExibirNoCustomizador { get; set; }
}