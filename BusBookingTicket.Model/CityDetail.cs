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
    
    public partial class CityDetail
    {
        public CityDetail()
        {
            this.Routes = new HashSet<Route>();
            this.Routes1 = new HashSet<Route>();
        }
    
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    
        public virtual StateDetail StateDetail { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
        public virtual ICollection<Route> Routes1 { get; set; }
    }
}
