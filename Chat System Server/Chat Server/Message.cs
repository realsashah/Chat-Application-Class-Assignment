//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chat_Server
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public decimal message_id { get; set; }
        public decimal sender_id { get; set; }
        public decimal reciever_id { get; set; }
        public string message_text { get; set; }
    }
}
