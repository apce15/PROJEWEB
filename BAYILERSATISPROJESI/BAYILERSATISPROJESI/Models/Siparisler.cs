//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations.Schema;
namespace BAYILERSATISPROJESI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparisler
    {
        public int Id { get; set; }
        public int BayiId { get; set; }
        public int UrunId { get; set; }
        public System.DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        [NotMapped]
        public int Miktar { get; set; }

    }
}
