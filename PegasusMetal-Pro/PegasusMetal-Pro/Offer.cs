//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PegasusMetal_Pro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offer
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal ProfitPercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal LastPrice { get; set; }
        public string ProjectPreparation { get; set; }
    
        public virtual AcceptedOffer AcceptedOffer { get; set; }
        public virtual Project Project { get; set; }
    }
}