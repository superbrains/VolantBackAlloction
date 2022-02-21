using AutoMapper;
using BAServices.Models;
using BAServices.ViewModels.Operators;
using System;
using System.Collections.Generic;
using System.Text;

using VolantBackAlloction.ViewModels.Tenant;

namespace BAServices
{
    public class MyProfiles : Profile
    {
        public MyProfiles()
        {
            CreateMap<TenantVM,Tenants >().ReverseMap();
            CreateMap<OperatorVM, Operators>().ReverseMap();
        }
    }
}
