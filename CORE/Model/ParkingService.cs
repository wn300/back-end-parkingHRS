//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CORE.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParkingService
    {
        public int Id { get; set; }
        public int IdRate { get; set; }
        public int IdVehicle { get; set; }
        public System.DateTime DateTimeEntry { get; set; }
        public System.DateTime DateTimeExit { get; set; }
        public decimal ServicePrice { get; set; }
    
        public virtual Rates Rates { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}