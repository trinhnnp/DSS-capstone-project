//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSS.Data.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlaylistViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<DSS.Data.Models.Entities.Playlist>
    {
    	
    			public virtual int PlaylistID { get; set; }
    			public virtual string Title { get; set; }
    			public virtual string Description { get; set; }
    	
    	public PlaylistViewModel() : base() { }
    	public PlaylistViewModel(DSS.Data.Models.Entities.Playlist entity) : base(entity) { }
    
    }
}
