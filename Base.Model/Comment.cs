//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base.Model
{
    using System;
    using System.Collections.Generic;


    public partial class Comment
    {
        public int ID { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int NewsID { get; set; }
    }
}
