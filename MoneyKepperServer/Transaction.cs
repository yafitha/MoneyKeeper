//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyKepperServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int CategoryID { get; set; }
        public double Amount { get; set; }
        public string Note { get; set; }
        public byte[] IsActive { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
