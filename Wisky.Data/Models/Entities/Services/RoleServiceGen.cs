//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wisky.Data.Models.Entities.Services
{
    using System;
    using System.Collections.Generic;
    
    
    public partial interface IRoleService : SkyWeb.DatVM.Data.IBaseService<Role>
    {
    }
    
    public partial class RoleService : SkyWeb.DatVM.Data.BaseService<Role>, IRoleService
    {
        public RoleService(SkyWeb.DatVM.Data.IUnitOfWork unitOfWork, Repositories.IRoleRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}