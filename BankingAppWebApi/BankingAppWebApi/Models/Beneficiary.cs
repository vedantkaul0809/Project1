//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingAppWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Beneficiary
    {
        public int BId { get; set; }
        public long HolderAccountNumber { get; set; }
        public long BeneficiaryAccountNumber { get; set; }
        public Nullable<int> BeneficiaryId { get; set; }
        public string Nickname { get; set; }
    
        public UserDetails UserDetail { get; set; }
        public Customer Customer { get; set; }
        public Customer Customer1 { get; set; }
    }
}
