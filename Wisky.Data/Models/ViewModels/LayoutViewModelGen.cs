//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wisky.Data.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class LayoutViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<Wisky.Data.Models.Entities.Layout>
    {
    	
    			public virtual int LayoutID { get; set; }
    			public virtual string Title { get; set; }
    			public virtual int AreasNum { get; set; }
    	
    	public LayoutViewModel() : base() { }
    	public LayoutViewModel(Wisky.Data.Models.Entities.Layout entity) : base(entity) { }
    
    }
}
