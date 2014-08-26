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
    
    public partial class UserDetail
    {
        public UserDetail()
        {
            this.PassangerDetails = new HashSet<PassangerDetail>();
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PasswordOfUser { get; set; }
        public Nullable<int> MobileNumber { get; set; }
        public string NameOfCardHolder { get; set; }
        public string Address { get; set; }
        public Nullable<int> Pincode { get; set; }
    
        public virtual ICollection<PassangerDetail> PassangerDetails { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
