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
    
    public partial class DetalheCompra
    {
        public int Quantidade { get; set; }
        public int ProdutoCodProduto { get; set; }
        public int CompraNrCompra1 { get; set; }
    
        public virtual Produto Produtos { get; set; }
        public virtual Compra Compras { get; set; }
    }
}
