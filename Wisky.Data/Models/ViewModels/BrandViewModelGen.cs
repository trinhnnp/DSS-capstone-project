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
    
    public partial class BrandViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<Wisky.Data.Models.Entities.Brand>
    {
    	
    			public virtual int BrandID { get; set; }
    			public virtual string BrandName { get; set; }
    			public virtual string CreateDateTime { get; set; }
    			public virtual string Description { get; set; }
    	
    	public BrandViewModel() : base() { }
    	public BrandViewModel(Wisky.Data.Models.Entities.Brand entity) : base(entity) { }
    
    }
}
