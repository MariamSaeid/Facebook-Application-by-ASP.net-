//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacebookPro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FriendsRel
    {
        public int ID { get; set; }
        public int FReceiver { get; set; }
        public int FSender { get; set; }
    
        public virtual UserDetails UserDetails { get; set; }
        public virtual UserDetails UserDetails1 { get; set; }
    }
}