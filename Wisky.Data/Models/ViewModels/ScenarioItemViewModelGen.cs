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
    
    public partial class ScenarioItemViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<DSS.Data.Models.Entities.ScenarioItem>
    {
    	
    			public virtual int ScenarioItemID { get; set; }
    			public virtual int PlaylistID { get; set; }
    			public virtual int ScenarioID { get; set; }
    			public virtual int AreaID { get; set; }
    			public virtual int DisplayOrder { get; set; }
    			public virtual string Note { get; set; }
    	
    	public ScenarioItemViewModel() : base() { }
    	public ScenarioItemViewModel(DSS.Data.Models.Entities.ScenarioItem entity) : base(entity) { }
    
    }
}
