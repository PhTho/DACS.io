//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToyStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QA
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int UserAskID { get; set; }
        public bool Status { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Nullable<System.DateTime> DateQuestion { get; set; }
        public Nullable<System.DateTime> DateAnswer { get; set; }
        public int UserAnswerID { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}