//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookids
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participação
    {
        public int EscolaIdEscola { get; set; }
        public int EventoNrEvento { get; set; }
    
        public virtual Escola Escolas { get; set; }
        public virtual Evento Eventos { get; set; }
    }
}
