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
    
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            this.DetalheCompras = new HashSet<DetalheCompra>();
        }
    
        public int NrCompra { get; set; }
        public int ClienteIdPessoa { get; set; }
        public System.DateTime Data { get; set; }
        public bool UtilizouCartão { get; set; }
    
        public virtual Cliente Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalheCompra> DetalheCompras { get; set; }
    }
}
