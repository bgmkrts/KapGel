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
    
    public partial class ProductComment
    {
        public int Id { get; set; }
        public Nullable<int> customerId { get; set; }
        public Nullable<int> productId { get; set; }
        public string commentMessage { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
        public Nullable<bool> productCommentCase { get; set; }
    }
}