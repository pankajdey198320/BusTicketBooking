//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusBookingTicket.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusCompany
    {
        public BusCompany()
        {
            this.BusDetails = new HashSet<BusDetail>();
        }
    
        public int Id { get; set; }
        public string BusCompanyName { get; set; }
    
        public virtual ICollection<BusDetail> BusDetails { get; set; }
    }
}