//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wisky.Data.Models.Entities.Repositories
{
    using System;
    using System.Collections.Generic;
    
    
    public partial interface IAreaRepository : SkyWeb.DatVM.Data.IBaseRepository<Area>
    {
    }
    
    public partial class AreaRepository : SkyWeb.DatVM.Data.BaseRepository<Area>, IAreaRepository
    {
    	public AreaRepository(System.Data.Entity.DbContext dbContext) : base(dbContext)
        {
        }
    }
}
