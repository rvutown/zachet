//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdItem
    {
        public int IdOrd { get; set; }
        public int IdProd { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
