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
    
    public partial class Comments
    {
        public int ID { get; set; }
        public string Comment_txt { get; set; }
        public int User_ID { get; set; }
        public int Post_ID { get; set; }
    
        public virtual Posts Posts { get; set; }
        public virtual UserDetails UserDetails { get; set; }
    }
}