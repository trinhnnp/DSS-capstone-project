//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSS.Data.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlaylistItem
    {
        public int PlaylistItemID { get; set; }
        public int MediaSrcID { get; set; }
        public int PlaylistID { get; set; }
        public int DisplayOrder { get; set; }
        public string Duration { get; set; }
    
        public virtual MediaSrc MediaSrc { get; set; }
        public virtual Playlist Playlist { get; set; }
    }
}
