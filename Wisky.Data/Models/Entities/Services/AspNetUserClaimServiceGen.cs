//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSS.Data.Models.Entities.Services
{
    using System;
    using System.Collections.Generic;
    
    
    public partial interface IAspNetUserClaimService : SkyWeb.DatVM.Data.IBaseService<AspNetUserClaim>
    {
    }
    
    public partial class AspNetUserClaimService : SkyWeb.DatVM.Data.BaseService<AspNetUserClaim>, IAspNetUserClaimService
    {
        public AspNetUserClaimService(SkyWeb.DatVM.Data.IUnitOfWork unitOfWork, Repositories.IAspNetUserClaimRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
