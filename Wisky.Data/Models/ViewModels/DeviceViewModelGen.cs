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
    
    public partial class DeviceViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<Wisky.Data.Models.Entities.Device>
    {
    	
    			public virtual int DeviceID { get; set; }
    			public virtual int ScreenID { get; set; }
    			public virtual int BoxID { get; set; }
    			public virtual string CreateDatetime { get; set; }
    			public virtual string Description { get; set; }
    	
    	public DeviceViewModel() : base() { }
    	public DeviceViewModel(Wisky.Data.Models.Entities.Device entity) : base(entity) { }
    
    }
}
