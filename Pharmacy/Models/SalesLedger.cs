//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesLedger
    {
        public int Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> BalanceAmount { get; set; }
        public Nullable<int> CreditAmount { get; set; }
        public Nullable<int> DebitAmount { get; set; }
        public string Particulars { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual SalesInvoice SalesInvoice { get; set; }
    }
}
