//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KapGel.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int Id { get; set; }
        public Nullable<int> marketId { get; set; }
        public Nullable<int> categoryId { get; set; }
        public string productName { get; set; }
        public Nullable<short> stockNumber { get; set; }
        public Nullable<byte> discountRate { get; set; }
        public Nullable<byte> productPoint { get; set; }
        public int price { get; set; }
    }
}
